using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using TextBox = System.Windows.Forms.TextBox;

namespace Projeto_TCC
{
    public partial class TelaOrdem : Form
    {
        private string connectionString = "Server=localhost;Uid=root;Database=projeto;Port=3306;";

        public TelaOrdem()
        {
            InitializeComponent();

            PreencherSetor();

            timer1_Tick(this, EventArgs.Empty);
        }
        public void Alert(string msg, FormAlert.enmType type)
        {
            FormAlert frm = new FormAlert();
            frm.showAlert(msg, type);
        }

        private void PreencherSetor()
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    //PREENCHER COMBOBOX SETOR
                    string query = "SELECT Nome FROM setor";

                    MySqlDataAdapter dataAdapter = new MySqlDataAdapter(query, connection);
                    DataTable dataTable = new DataTable();
                    dataAdapter.Fill(dataTable);

                    DataRow row = dataTable.NewRow();
                    row["Nome"] = "Escolha um setor!";
                    dataTable.Rows.InsertAt(row, 0);

                    cmbSetor.DataSource = dataTable;
                    cmbSetor.DisplayMember = "Nome";
                    cmbSetor.SelectedIndex = 0;
                }
                catch (Exception ex)
                {
                    Alert("Erro de conexão com o banco de dados!", FormAlert.enmType.Error);
                    //MessageBox.Show("Erro ao preencher a ComboBox: " + ex.Message);
                }
            }
        }
        private void cmbSetor_SelectedIndexChanged(object sender, EventArgs e)
        {
            PreencherMaquina(cmbSetor.SelectedIndex);
        }

        private void PreencherMaquina(int setor)
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    string query = "SELECT Nome FROM maquina WHERE Setor = @Setor";

                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Setor",setor);

                        MySqlDataAdapter dataAdapter = new MySqlDataAdapter(command);
                        DataTable dataTable = new DataTable();
                        dataAdapter.Fill(dataTable);

                        DataRow row = dataTable.NewRow();
                        row["Nome"] = "Escolha uma máquina!";
                        dataTable.Rows.InsertAt(row, 0);

                        cmbMaquina.DataSource = dataTable;
                        cmbMaquina.DisplayMember = "Nome";
                        cmbMaquina.SelectedIndex = 0;
                    }             
                    
                }
                catch(Exception ex)
                {
                    Alert("Erro de conexão com o banco de dados!", FormAlert.enmType.Error);
                    //MessageBox.Show("Erro ao preencher a ComboBox: " + ex.Message);
                }
            }
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            string connectionString = "Server=localhost;Uid=root;Database=projeto;Port=3306;";

            //VALIDAÇÕES DE CRIAÇÃO
            if (cmbSetor.SelectedIndex == 0)
            {
                Alert("Selecione um setor!", FormAlert.enmType.Info);
                return;
            }
            if (cmbMaquina.SelectedIndex == 0)
            {
                Alert("Selecione uma máquina!", FormAlert.enmType.Info);
                return;
            }
            if (string.IsNullOrEmpty(txtDescricao.Text))
            {
                Alert("Informe a descrição!", FormAlert.enmType.Info);
                return;
            }

            //CRIA UMA NOVA CONEXÃO COM O BANCO DE DADOS MYSQL USANDO A STRING FORNECIDA
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {

                try
                {
                    //ABRE A CONEXÃO DO BANCO DE DADOS
                    connection.Open();
                    //FAZER VALIDAÇÕES
                    int id = UsuarioSessao.UsuarioAtual.ID;
                    int setor = cmbSetor.SelectedIndex;
                    int maquina = 0;
                    string descricao = txtDescricao.Text;
                    string data = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");

                    string selectQuery = "SELECT ID_Maquina FROM maquina WHERE Setor = @Setor AND Nome = @Nome";

                    using (MySqlCommand cmd = new MySqlCommand(selectQuery, connection))
                    {
                        cmd.Parameters.AddWithValue("@Setor",setor);
                        cmd.Parameters.AddWithValue("@Nome",cmbMaquina.Text);
                        cmd.ExecuteNonQuery();

                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                maquina = Convert.ToInt32(reader["ID_Maquina"]);
                            }
                        }
                    }

                    //DEFINE A CONSULTA SQL PARA INSERIR UM NOVO CLIENTE NA TABELA PASSANDO PARÂMETROS
                    string insertQuery = "INSERT INTO abertura_ordem (ID_Funcionario, ID_Setor, ID_Maquina, Data_Abertura, Descricao, Status) VALUES (@ID, @Setor, @Maquina, @Data, @Descricao, 1)";

                    //CRIA O COMANDO SQL COM A CONSULTA E A CONEXÃO
                    using (MySqlCommand command = new MySqlCommand(insertQuery, connection))
                    {

                        //ADICIONA OS DADOS LIDOS COMO PARÂMETROS PARA CONSULTA
                        command.Parameters.AddWithValue("@ID", id);
                        command.Parameters.AddWithValue("@Setor", setor);
                        command.Parameters.AddWithValue("@Maquina", maquina);
                        command.Parameters.AddWithValue("@Data", data);
                        command.Parameters.AddWithValue("@Descricao", descricao);

                        //EXECUTA O COMANDO PARA INSERIR OS DADOS NO BANCO
                        command.ExecuteNonQuery();  //USADO PARA COMANDOS QUE NÃO RETORNAM RESULTADOS
                        Alert("A ordem foi registrada com sucesso!", FormAlert.enmType.Success);
                    }
                } catch (Exception ex)
                {
                    Alert("Erro de conexão com o banco de dados!", FormAlert.enmType.Error);
                    MessageBox.Show($"Erro: {ex.Message}", "ERRO!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                cmbSetor.SelectedIndex = 0;
                txtDescricao.Text = "";

            }
        }
        int valorDescricao = 0;
        private void txtDescricao_TextChanged(object sender, EventArgs e)
        {
            valorDescricao = txtDescricao.Text.Length;
            lblCaracteres.Text = $"{valorDescricao}/100";
        }

        private void txtDescricao_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (valorDescricao >= 100 && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime data = DateTime.Now;
            lblData.Text = data.ToString("HH:mm:ss - dd/MM/yyyy");
        }
    }
}

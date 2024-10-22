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
        //FORMATAÇÃO CAMPOS DE HORÁRIO
        private void Format_Hora(object sender, EventArgs e)
        {
            string hora = (sender as TextBox).Text.Replace(":", "");
            if (hora.Length > 2)
            {
                hora = hora.Substring(0, 2) + ":" + hora.Substring(2);
            }
            (sender as TextBox).Text = hora;
            (sender as TextBox).SelectionStart = (sender as TextBox).Text.Length;
        }
        //VALIDAÇÃO CARACTERES CAMPOS DE HORÁRIO
        private void ValidarHora(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                //MessageBox.Show("Este campo aceita somente números.", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                Alert("Este campo aceita somente números!", FormAlert.enmType.Info);
            }
            string numero = (sender as TextBox).Text;
            if (!char.IsControl(e.KeyChar) && numero.Length >= 5)
            {
                e.Handled = true;
            }
        }

        //FORMATAÇÃO CAMPOS DE DATA
        private void Format_Data(object sender, EventArgs e)
        {
            string data = (sender as TextBox).Text.Replace("/", "");
            if (data.Length > 2)
            {
                data = data.Substring(0, 2) + "/" + data.Substring(2);
            }
            if (data.Length > 5)
            {
                data = data.Substring(0, 5) + "/" + data.Substring(5);
            }
            (sender as TextBox).Text = data;
            (sender as TextBox).SelectionStart = (sender as TextBox).Text.Length;
        }

        //VALIDAÇÃO CARACTERES CAMPOS DE DATA
        private void ValidarData(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                //MessageBox.Show("Este campo aceita somente números.", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                Alert("Este campo aceita somente números!", FormAlert.enmType.Info);
            }
            string numero = (sender as TextBox).Text;
            if (!char.IsControl(e.KeyChar) && numero.Length >= 10)
            {
                e.Handled = true;
            }
        }

        private void roundedButton1_Click(object sender, EventArgs e)
        {
            string connectionString = "Server=localhost;Uid=root;Database=projeto;Port=3306;";

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
                    int maquina = cmbMaquina.SelectedIndex;
                    string descricao = txtDescricao.Text;
                    string data = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");

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

            }
        }
        int valorDescricao = 0;
        private void txtDescricao_TextChanged(object sender, EventArgs e)
        {
            valorDescricao = txtDescricao.Text.Length;
            lblCaracteres.Text = $"{valorDescricao}/50";
        }

        private void txtDescricao_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (valorDescricao >= 50 && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}

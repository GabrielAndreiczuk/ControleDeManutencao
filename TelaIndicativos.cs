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

namespace Projeto_TCC
{
    public partial class TelaIndicativos : Form
    {
        private string connectionString = "Server=localhost;Uid=root;Database=projeto;Port=3306;";

        public TelaIndicativos()
        {
            InitializeComponent();

            PreencherSetor();

            CarregarDados();          
        }

        private void TelaIndicativos_Load(object sender, EventArgs e)
        {
            Filtrar_Click(sender, EventArgs.Empty);
            toolTip1.SetToolTip(pibMTBF, 
            "MTBF é o tempo médio entre falhas de um equipamento ou sistema durante sua operação.\n" +
            "Ele avalia a confiabilidade do ativo, indicando quanto tempo, em média, ele opera sem\n" +
            "interrupções.");
            toolTip1.SetToolTip(pibMTTR, 
            "MTTR é o tempo médio necessário para reparar um equipamento ou sistema após uma falha.\n" +
            "Ele mede a eficiência das equipes de manutenção em restaurar a funcionalidade normal,\n" +
            "sendo um indicador chave na gestão de tempo de inatividade.");
        }
        public void Alert(string msg, FormAlert.enmType type)
        {
            FormAlert frm = new FormAlert();
            frm.showAlert(msg, type);
        }

        private void CarregarDados()
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string query = "";
                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        using (MySqlDataReader reader = command.ExecuteReader())
                        {
                            
                        }
                    }
                }
                catch (Exception ex)
                {
                    Alert("Erro de conexão com o banco de dados!", FormAlert.enmType.Error);
                    //MessageBox.Show(ex.Message);
                }
            }
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
                        command.Parameters.AddWithValue("@Setor", setor);

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
                catch (Exception ex)
                {
                    Alert("Erro de conexão com o banco de dados!", FormAlert.enmType.Error);
                    //MessageBox.Show("Erro ao preencher a ComboBox: " + ex.Message);
                }
            }
        }

        private void Filtrar_Click(object sender, EventArgs e)
        {
            if (pnlFiltros.Height == 150)
            {
                foreach (Control control in pnlFiltros.Controls)
                {
                    if (!(control is Panel) && (control != lblLine))
                    {
                        control.Visible = false;
                    }
                }
                pnlFiltros.Height = 52;
            }
            else
            {
                foreach (Control control in pnlFiltros.Controls)
                {
                    control.Visible = true;
                }
                pnlFiltros.Height = 150;
            }
            
        }
        private void LimparFiltros_Click(object sender, EventArgs e)
        {

        }

        private void roundedButton1_Click(object sender, EventArgs e)
        {
            string setor = cmbSetor.Text;
            string maquina = cmbMaquina.Text;

            

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    string query = "Select MTTR from MTTR where Setor = @setor AND Maquina = @maquina";
                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@setor", setor);
                        command.Parameters.AddWithValue("@maquina", maquina);
                        using (MySqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                TimeSpan tempo = (TimeSpan)reader["MTTR"];
                                double hrs = tempo.Hours + (tempo.Days * 24);
                                double min = tempo.Minutes;
                                string mttr = $"{hrs+(min/60):F1}";
                                lblMTTR.Text = mttr.ToString();
                            }
                        }
                    }

                    query = "Select MTBF from MTBF where Setor = @setor AND Maquina = @maquina";
                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@setor", setor);
                        command.Parameters.AddWithValue("@maquina", maquina);
                        using (MySqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                TimeSpan tempo = (TimeSpan)reader["MTBF"];
                                double hrs = tempo.Hours + (tempo.Days * 24);
                                double min = tempo.Minutes;
                                string mtbf = $"{hrs + (min / 60):F1}";
                                lblMTBF.Text = mtbf.ToString();
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    Alert("Erro de conexão com o banco de dados!", FormAlert.enmType.Error);
                    MessageBox.Show(ex.Message);
                }
            }
        }
    }    
}

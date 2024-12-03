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

            //DEFINE A DATA INICIAL COMO O PRIMEIRO DIA DO MÊS ATUAL
            dateInicial.MaxDate = DateTime.Now;
            dateInicial.Value = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);
            dateFinal.MaxDate = DateTime.Now;
            dateFinal.Value = DateTime.Now;            
        }

        private void TelaIndicativos_Load(object sender, EventArgs e)
        {
            Filtrar_Click(sender, EventArgs.Empty);
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

        private void dateInicial_ValueChanged(object sender, EventArgs e)
        {
            if (dateInicial.Value > dateFinal.Value)
            {
                dateFinal.Value = dateInicial.Value;
            }
        }
        //VERIFICA SE A DATA FINAL SELECIONADA É MENOR QUE A DATA INICIAL
        private void dateFinal_ValueChanged(object sender, EventArgs e)
        {
            if (dateInicial.Value > dateFinal.Value)
            {
                dateInicial.Value = dateFinal.Value;
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

        private void contentPanel_Paint(object sender, PaintEventArgs e)
        {

        }
    }    
}

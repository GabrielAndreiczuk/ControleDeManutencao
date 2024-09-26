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
    public partial class TelaOrdem : Form
    {
        private string connectionString = "Server=localhost;Uid=root;Database=projeto;Port=3306;";

        public TelaOrdem()
        {
            InitializeComponent();

            PreencherComboBox();
        }
        public void Alert(string msg, FormAlert.enmType type)
        {
            FormAlert frm = new FormAlert();
            frm.showAlert(msg, type);
        }

        private void PreencherComboBox()
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    //PREENCHER COMBOBOX SETOR
                    string query = "SELECT Nome FROM maquina";

                    MySqlDataAdapter dataAdapter = new MySqlDataAdapter(query, connection);
                    DataTable dataTable = new DataTable();
                    dataAdapter.Fill(dataTable);

                    DataRow row = dataTable.NewRow();
                    row["Nome"] = "Escolha uma máquina!";
                    dataTable.Rows.InsertAt(row, 0);

                    cmbMaquina.DataSource = dataTable;
                    cmbMaquina.DisplayMember = "Nome";
                    cmbMaquina.SelectedIndex = 0;
                }
                catch (Exception ex)
                {
                    Alert("Erro de conexão com o banco de dados!", FormAlert.enmType.Error);
                    //MessageBox.Show("Erro ao preencher a ComboBox: " + ex.Message);
                }
            }
        }
    }
}

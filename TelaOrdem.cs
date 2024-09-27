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

    }
}

using MySql.Data.MySqlClient;
using Mysqlx;
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
    public partial class TelaInclusaoPecas : Form
    {
        string connectionString = "Server=localhost;Uid=root;Database=projeto;Port=3306";

        public TelaInclusaoPecas()
        {
            InitializeComponent();
            PreencherPecas();
        }

        public void Alert(string msg, FormAlert.enmType type)
        {
            FormAlert frm = new FormAlert();
            frm.showAlert(msg, type);
        }

        //PREENCHIMENTO DA LISTA DE PEÇAS
        private void PreencherPecas()
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    //PREENCHER COMBOBOX SETOR
                    string query = "SELECT Nome FROM pecas";

                    MySqlDataAdapter dataAdapter = new MySqlDataAdapter(query, connection);
                    DataTable dataTable = new DataTable();
                    dataAdapter.Fill(dataTable);

                    DataRow row = dataTable.NewRow();
                    row["Nome"] = "Lista de peças!";
                    dataTable.Rows.InsertAt(row, 0);

                    cmbPecas.DataSource = dataTable;
                    cmbPecas.DisplayMember = "Nome";
                    cmbPecas.SelectedIndex = 0;
                }
                catch (Exception ex)
                {
                    Alert("Erro de conexão com o banco de dados!", FormAlert.enmType.Error);
                    //MessageBox.Show("Erro ao preencher a ComboBox: " + ex.Message);
                }
            }
        }

        //CÓDIGO DE EXPOSIÇÃO DE INFORMAÇÕES DA PEÇA SELECIONADA
        private void cmbPecas_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbPecas.SelectedIndex == 0)
            {
                lblEstoque.Visible = false;
                label1.Visible = false;
                label3.Visible = false;
                numQuantidade.Visible = false;
                btnRegistrar.Visible = false;
                return;
            }

            lblEstoque.Visible = true;
            label1.Visible = true;
            label3.Visible = true;
            numQuantidade.Visible = true;
            btnRegistrar.Visible = true;

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {                
                try
                {
                    connection.Open();

                    string selectQuery = "Select Estoque from pecas where ID_Pecas = @ID";

                    using (MySqlCommand command = new MySqlCommand(selectQuery, connection))
                    {
                        command.Parameters.AddWithValue("@ID", cmbPecas.SelectedIndex);
                        command.ExecuteNonQuery();

                        using (MySqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                lblEstoque.Text = $"{reader["Estoque"].ToString()} unidades em estoque!";
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }

        }

        public string Nome
        {
            get { return cmbPecas.Text; }
        }
        public int Quantidade
        {
            get { return (int) numQuantidade.Value; }
        }
        public int idPecas
        {
            get { return cmbPecas.SelectedIndex; }
        }

        //PROGRAMAÇÃO DO BOTÃO DE REGISTRO
        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //EVENTOS BOTÕES CONTROLES DE TELA - FECHAR
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //EVENTOS BOTÕES CONTROLES DE TELA - MAXIMIZAR
        private void btnMaximize_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
                this.WindowState = FormWindowState.Maximized;
            else
                this.WindowState = FormWindowState.Normal;
        }
        //EVENTOS BOTÕES CONTROLES DE TELA - MINIMIZAR
        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        //HOOVER CONTROLES DE TELA - FECHAR
        private void pibFechar_MouseHover(object sender, EventArgs e)
        {
            //BackColor = Color.FromArgb(54, 124, 200);
            pibFechar.BackColor = Color.Red;
            labelClose.BackColor = Color.Red;
        }
        //HOOVER CONTROLES DE TELA - MAXIMIZAR
        private void pibMaximizar_MouseHover(object sender, EventArgs e)
        {
            pibMaximizar.BackColor = Color.FromArgb(0, 36, 72);
            lblMaximizar.BackColor = Color.FromArgb(0, 36, 72);
        }
        //HOOVER CONTROLES DE TELA - MINIMIZAR
        private void pibMinimizar_MouseHover(object sender, EventArgs e)
        {
            pibMinimizar.BackColor = Color.FromArgb(0, 36, 72);
            lblMinimizar.BackColor = Color.FromArgb(0, 36, 72);
        }
        //HOOVER CONTROLES DE TELA - RESET DO ESTILO
        private void ResetBackground_MouseLeave(object sender, EventArgs e)
        {
            pibFechar.BackColor = Color.FromArgb(0, 51, 102);
            pibMaximizar.BackColor = Color.FromArgb(0, 51, 102);
            pibMinimizar.BackColor = Color.FromArgb(0, 51, 102);
            labelClose.BackColor = Color.FromArgb(0, 51, 102);
            lblMaximizar.BackColor = Color.FromArgb(0, 51, 102);
            lblMinimizar.BackColor = Color.FromArgb(0, 51, 102);
        }  
    }
}

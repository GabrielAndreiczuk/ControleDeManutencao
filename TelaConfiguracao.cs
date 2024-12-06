using MySql.Data.MySqlClient;
using Org.BouncyCastle.Asn1.Cmp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_TCC
{
    public partial class TelaConfiguracao : Form
    {
        //MÉTODO QUE INSTANCIA E CHAMA NOTIFICAÇÕES PERSONALIZADAS
        public void Alert(string msg, FormAlert.enmType type)
        {
            FormAlert frm = new FormAlert();
            frm.showAlert(msg, type);
        }

        private string connectionString = "Server=localhost;Uid=root;Database=projeto;Port=3306;";

        public TelaConfiguracao()
        {
            InitializeComponent();

            CarregarDados();
            PreencherComboBox();
        }

        //MÉTODO QUE CARREGA DADOS DO USUÁRIO DO BANCO
        private void CarregarDados()
        {
            lblUsuario.Text = UsuarioSessao.UsuarioAtual.Nome;
            lblID.Text = $"ID: {UsuarioSessao.UsuarioAtual.ID}";
            txtEmail.Text = UsuarioSessao.UsuarioAtual.Email;
            lblCargoUsuario.Text = UsuarioSessao.UsuarioAtual.Cargo;
            lblSetorUsuario.Text = UsuarioSessao.UsuarioAtual.Setor;
        }

        //FAZ LOGOUT DO USUÁRIO
        private void btnSair_Click(object sender, EventArgs e)
        {
            TelaMenu menu = new TelaMenu();
            menu.Logout();
        }

        //HABILITA A ALTERAÇÃO DE EMAIL
        private void pibEmail_Click(object sender, EventArgs e)
        {
            txtEmail.ReadOnly = false;
            txtEmail.Focus();

            btnConfirmar.Visible = true;
        }

        //HABILITA A ALTERAÇÃO DE CARGO
        private void pibCargo_Click(object sender, EventArgs e)
        {
            lblCargo.Visible = true;
            cmbCargo.Visible = true;
            lblCargoTitulo.Visible = true;

            btnConfirmar.Visible = true;
        }

        //HABILITA A ALTERAÇÃO DE SETOR
        private void pibSetor_Click(object sender, EventArgs e)
        {
            lblSetor.Visible = true;
            cmbSetor.Visible = true;
            lblSetorTitulo.Visible = true;

            btnConfirmar.Visible = true;
        }

        //HABILITA A ALTERAÇÃO DE CONTATO
        private void pibContato_Click(object sender, EventArgs e)
        {
            txtContato.ReadOnly = false;
            txtContato.Focus();

            btnConfirmar.Visible = true;
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            
            //VALIDAÇÃO VALORES DAS COMBOBOX
            if (cmbSetor.SelectedIndex == 0)
            {
                Alert("Escolha uma opção de setor válida!", FormAlert.enmType.Warning);
                return;
            }
            int setor = cmbSetor.SelectedIndex;
            string updateSetor = "\"Setor\" = @setor";
            if (cmbCargo.SelectedIndex == 0)
            {
                Alert("Escolha uma opção de cargo válida!", FormAlert.enmType.Warning);
                return;
            }
            int cargo = cmbCargo.SelectedIndex;
            string updateCargo = "\"Cargo\" = @cargo";
            //VALIDÃÇÃO TEXTBOX CONTATO
            if (txtContato.Text.Length < 15)
            {
                Alert("Prencha o campo de contato corretamente!", FormAlert.enmType.Warning);
                txtContato.Focus();
                return;
            }
            string contato = txtContato.Text;
            string updateContato = "\"Contato\" = @contato";
            //VERFICAR SE O EMAIL ESTA NO FORMATO CORRETO
            string TesteEmail = txtEmail.Text;
            string pattern = @"^[^@\s]+@[^@\s]+\.(com)$";
            string pattern2 = @"^[^@\s]+@[^@\s]+\.(com).(br)$";
            Regex regex = new Regex(pattern, RegexOptions.IgnoreCase);
            Regex regex2 = new Regex(pattern2, RegexOptions.IgnoreCase);
            if (!regex.IsMatch(TesteEmail) && !regex2.IsMatch(TesteEmail))
            {
                Alert("Email no formato incorreto!", FormAlert.enmType.Warning);
                return;

            }
            string email = txtEmail.Text;
            string updateEmail = "\"Email\" = @email";

            //CONEXÃO COM O BANCO DE DADOS
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();                 

                    string updateQuery = "UPDATE funcionario SET Setor = @Setor, Cargo = @Cargo, Contato = @Contato, Email = @Email WHERE ID_Funcionario = @ID";

                    using (MySqlCommand command = new MySqlCommand(updateQuery, connection))
                    {
                        command.Parameters.AddWithValue("@Email", email);
                        command.Parameters.AddWithValue("@Setor", setor);
                        command.Parameters.AddWithValue("@Cargo", cargo);
                        command.Parameters.AddWithValue("@Contato", contato);
                        command.Parameters.AddWithValue("@ID", UsuarioSessao.UsuarioAtual.ID);

                        command.ExecuteNonQuery();
                    }
                    Alert("Seus dados foram atualizados!", FormAlert.enmType.Success);
                    CarregarDados();
                    resetTela();
                }
                catch (Exception ex)
                {
                    Alert("Erro de conexão com o banco de dados!", FormAlert.enmType.Error);
                }
            }
        }

        //MÉTODO QUE PREENCHE AS COMBOBOX COM INFORMAÇÕES DO BANCO DE DADOS
        private void PreencherComboBox()
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
                    row["Nome"] = "Escolha seu Setor!";
                    dataTable.Rows.InsertAt(row, 0);

                    cmbSetor.DataSource = dataTable;
                    cmbSetor.DisplayMember = "Nome";
                    //cmbSetor.ValueMember = "ID_Ferramenta";
                    cmbSetor.SelectedIndex = 0;

                    //PREENCHER COMBOBOX CARGO
                    query = "SELECT Nome FROM cargo";

                    MySqlDataAdapter dataAdapterCargo = new MySqlDataAdapter(query, connection);
                    DataTable dataTableCargo = new DataTable();
                    dataAdapterCargo.Fill(dataTableCargo);

                    DataRow rowCargo = dataTableCargo.NewRow();
                    rowCargo["Nome"] = "Escolha seu Cargo!";
                    dataTableCargo.Rows.InsertAt(rowCargo, 0);

                    cmbCargo.DataSource = dataTableCargo;
                    cmbCargo.DisplayMember = "Nome";
                }
                catch (Exception ex)
                {
                    Alert("Erro de conexão com o banco de dados!", FormAlert.enmType.Error);
                    //MessageBox.Show("Erro ao preencher a ComboBox: " + ex.Message);
                }
            }
        }

        //MÉTODO QUE FORMATA DINAMINAMENTE O CAMPO DE CONTATO
        private void ContactFormatting(object sender, EventArgs e)
        {
            //Remove qualquer formatação existente
            string numero = txtContato.Text.Replace("(", "").Replace(")", "").Replace("-", "").Replace(" ", "");
            if (numero.Length > 2)
            {
                numero = "(" + numero.Substring(0, 2) + ") " + numero.Substring(2);
            }
            if (numero.Length > 10)
            {
                numero = numero.Substring(0, 10) + "-" + numero.Substring(10);
            }
            txtContato.Text = numero;
            txtContato.SelectionStart = txtContato.Text.Length;
        }

        //VALIDAÇÃO CARACTERES CAMPO DE CONTATO
        private void onlyDigit(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                //MessageBox.Show("Este campo aceita somente números.", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                Alert("Este campo aceita somente números!", FormAlert.enmType.Info);
            }
            string numero = txtContato.Text;
            if (!char.IsControl(e.KeyChar) && numero.Length >= 15)
            {
                e.Handled = true;
            }
        }

        //VALIDAÇÃO EMAIL DO USUÁRIO
        private void validacaoEmail(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar == '@') && ((sender as TextBox).Text.IndexOf('@') > -1))
            {
                e.Handled = true;
                Alert("Este campo aceita somente um arroba.", FormAlert.enmType.Info);
                //MessageBox.Show("Este campo aceita somente um arroba.", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void resetTela()
        {
            txtContato.ReadOnly = true;
            txtEmail.ReadOnly = true;

            lblSetor.Visible = false;
            cmbSetor.Visible = false;
            lblSetorTitulo.Visible = false;

            lblCargo.Visible = false;
            cmbCargo.Visible = false;
            lblCargoTitulo.Visible = false;

            btnConfirmar.Visible = false;
        }
    }
}

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
            txtContato.Text = UsuarioSessao.UsuarioAtual.Contato;
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
            //VALIDÃÇÃO TEXTBOX CONTATO
            if (txtContato.Text.Length < 15)
            {
                Alert("Prencha o campo de contato corretamente!", FormAlert.enmType.Warning);
                txtContato.Focus();
                return;
            }

            

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


            //CONEXÃO COM O BANCO DE DADOS
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();               

                    //FAZ O UPDATE CASO UM SETOR DIFERENTE TENHA SIDO SELECIONADO
                    if (cmbSetor.SelectedIndex != 0)
                    {
                        string query = "SELECT ID_Setor from setor Where Nome = @setor";
                        int idSetor = 0;
                        using (MySqlCommand command = new MySqlCommand(query, connection))
                        {
                            command.Parameters.AddWithValue("@setor", cmbSetor.Text);
                            using (MySqlDataReader reader = command.ExecuteReader())
                            {
                                if (reader.Read())
                                {
                                    idSetor = reader.GetInt32("ID_Setor");
                                }
                            }
                        }
                        query = "UPDATE funcionario set Setor = @setor WHERE ID_Funcionario = @ID";
                        using (MySqlCommand command = new MySqlCommand(query, connection))
                        {
                            command.Parameters.AddWithValue("@setor",idSetor);
                            command.Parameters.AddWithValue("@ID", UsuarioSessao.UsuarioAtual.ID);

                            command.ExecuteNonQuery();
                        }
                        //ATUALIZA O DADO DA CLASSE
                        UsuarioSessao.UsuarioAtual.Setor = cmbSetor.Text;
                    }

                    //FAZ O UPDATE CASO UM CARGO DIFERENTE TENHA SIDO SELECIONADO
                    if (cmbCargo.SelectedIndex != 0)
                    {
                        string query = "SELECT ID_Cargo from cargo Where Nome = @cargo";
                        int idCargo = 0;
                        using (MySqlCommand command = new MySqlCommand(query, connection))
                        {
                            command.Parameters.AddWithValue("@cargo", cmbCargo.Text);
                            using (MySqlDataReader reader = command.ExecuteReader())
                            {
                                if (reader.Read())
                                {
                                    idCargo = reader.GetInt32("ID_Cargo");
                                }
                            }
                        }
                        query = "UPDATE funcionario set Cargo = @cargo WHERE ID_Funcionario = @ID";
                        using (MySqlCommand command = new MySqlCommand(query, connection))
                        {
                            command.Parameters.AddWithValue("@cargo", idCargo);
                            command.Parameters.AddWithValue("@ID", UsuarioSessao.UsuarioAtual.ID);

                            command.ExecuteNonQuery();
                        }
                        UsuarioSessao.UsuarioAtual.Cargo = cmbCargo.Text;
                    }

                    //ATUALIZA OS DADOS DE EMAIL E CONTATO DO FUNCIONARIO
                    string updateQuery = "UPDATE funcionario SET  Contato = @Contato, Email = @Email WHERE ID_Funcionario = @ID";

                    string contato = txtContato.Text;
                    string email = txtEmail.Text;

                    using (MySqlCommand command = new MySqlCommand(updateQuery, connection))
                    {
                        command.Parameters.AddWithValue("@Contato", contato);
                        command.Parameters.AddWithValue("@Email", email);                     
                        command.Parameters.AddWithValue("@ID", UsuarioSessao.UsuarioAtual.ID);

                        command.ExecuteNonQuery();
                    }

                    UsuarioSessao.UsuarioAtual.Email = txtEmail.Text;
                    UsuarioSessao.UsuarioAtual.Contato = txtContato.Text;

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

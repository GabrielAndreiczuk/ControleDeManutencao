using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using TextBox = System.Windows.Forms.TextBox;

namespace Projeto_TCC
{
    public partial class TelaCadastro : Form
    {
        public TelaCadastro()
        {
            InitializeComponent();
        }

        //MÉTODO QUE INSTANCIA E CHAMA NOTIFICAÇÕES PERSONALIZADAS
        public void Alert(string msg, FormAlert.enmType type)
        {
            FormAlert frm = new FormAlert();
            frm.showAlert(msg, type);
        }

        //VALIDAÇÃO NOME DO USUÁRIO
        private void validacaoNome(object sender, KeyPressEventArgs e)
        {          
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && (e.KeyChar != ' '))
            {
                e.Handled = true;
                Alert("Este campo aceita somente letras.", FormAlert.enmType.Info);
                //MessageBox.Show("Este campo aceita somente letras.", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
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

        //EVENTOS DE HOOVER LINK PARA LOGIN
        private void lblLogin_MouseEnter(object sender, EventArgs e)
        {
            this.lblLogin.Font = new Font(this.lblLogin.Font, FontStyle.Italic | FontStyle.Bold);
            this.lblLogin.ForeColor = Color.Yellow;
        }
        private void lblLogin_MouseLeave(object sender, EventArgs e)
        {
            this.lblLogin.Font = new Font(this.lblLogin.Font, FontStyle.Italic);
            this.lblLogin.ForeColor = Color.White;
        }

        //VOLTA PARA A PÁGINA DE LOGIN
        private void lblLogin_Click(object sender, EventArgs e)
        {
            TelaInicial tela = new TelaInicial();
            tela.IniciarLogin();
        }

        //VERIFICAÇÃO DE COMPATIBILIDADE DAS SENHAS
        private void checkPassword(object sender, EventArgs e)
        {
            if (txtSenhaConfirm.Text != "")
            {
                string passowrd = txtSenha.Text;
                if (txtSenhaConfirm.Text != passowrd)
                {
                    lblSenha.Show();
                    lblSenha.ForeColor = Color.Yellow;
                    lblSenha.Text = "As senhas não coincidem!";
                }
                else
                {
                    lblSenha.Show();
                    lblSenha.ForeColor = Color.Chartreuse;
                    lblSenha.Text = "Ótimo! As senhas estão iguais.";

                }
            }
        }

        //PROGRAMAÇÃO DO BOTÃO DE CADASTRO
        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            //VERIFICAR SE TODOS OS CAMPOS ESTÃO PREENCHIDOS
            if(txtNome.Text == "" || txtEmail.Text == "" || txtSenha.Text == "" || txtSenhaConfirm.Text == "")
            {
                FormAlert frm = new FormAlert();
                //ADAPTAR NOTIFICAÇÕES
                Alert("Por favor, preencha todos os campos.", FormAlert.enmType.Warning);
                return; // Sai do método para impedir a execução de código adicional
            }

            //VERFICAR SE O EMAIL ESTA NO FORMATO CORRETO
            string TesteEmail = txtEmail.Text;
            string pattern = @"^[^@\s]+@[^@\s]+\.(com)$";
            Regex regex = new Regex(pattern, RegexOptions.IgnoreCase);
            if (!regex.IsMatch(TesteEmail))
            {
                Alert("Email no formato incorreto!", FormAlert.enmType.Warning);
                return;
                
            }
            
            //VERIFICAR SE AS SENHAS SÃO IGUAIS
            if(txtSenha.Text != txtSenhaConfirm.Text)
            {
                Alert("Senhas não coincidem!", FormAlert.enmType.Warning);
                return;
            }

            //ATRIBUI VALOR A UMA STRING DE CONEXÃO INFORMANDO DADOS DO BANCO UTILIZADO
            string connectionString = "Server=localhost;Uid=root;Database=projeto;Port=3306;";

            //CRIA UMA NOVA CONEXÃO COM O BANCO DE DADOS MYSQL USANDO A STRING FORNECIDA
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {

                try
                {
                    //ABRE A CONEXÃO DO BANCO DE DADOS
                    connection.Open();

                    string nome = txtNome.Text;
                    string email = txtEmail.Text;                
                    string senha = txtSenha.Text;

                    //CONSULTA PARA OBTER A LISTA DE EMAILS CADASTRADOS
                    string emailQuery = "SELECT Email FROM funcionario";
                    bool cadastrado = false;

                    //VERIFICA SE O EMAIL JÁ ESTÁ CADASTRADO
                    using (MySqlCommand command = new MySqlCommand(emailQuery, connection))
                    {
                        using (MySqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                string emailData = reader["Email"].ToString();
                                if (emailData == txtEmail.Text)
                                {
                                    cadastrado = true;
                                }
                            }
                            if (cadastrado == true)
                            {
                                Alert("Este email já está cadastrado!", FormAlert.enmType.Warning);
                                return;
                            }
                        }
                    }

                    //DEFINE ATRIBUTOS DO USUÁRIO LOGADO NO SISTEMA
                    UsuarioSessao.UsuarioAtual = new Usuario();
                    UsuarioSessao.UsuarioAtual.Nome = nome;
                    UsuarioSessao.UsuarioAtual.Email = email;
                    UsuarioSessao.UsuarioAtual.Senha = senha;

                    /*
                    //DEFINE A CONSULTA SQL PARA INSERIR UM NOVO CLIENTE NA TABELA PASSANDO PARÂMETROS
                    string insertQuery = "INSERT INTO funcionario (Nome, Email, Senha) VALUES (@Nome, @Email, @Senha)";

                    //CRIA O COMANDO SQL COM A CONSULTA E A CONEXÃO
                    using (MySqlCommand command = new MySqlCommand(insertQuery, connection))
                    {

                        //ADICIONA OS DADOS LIDOS COMO PARÂMETROS PARA CONSULTA
                        command.Parameters.AddWithValue("@Nome", nome);
                        command.Parameters.AddWithValue("@Email", email);
                        command.Parameters.AddWithValue("@Senha", senha);

                        //EXECUTA O COMANDO PARA INSERIR OS DADOS NO BANCO
                        command.ExecuteNonQuery();  //USADO PARA COMANDOS QUE NÃO RETORNAM RESULTADOS
                    */

                        //DIRECIONA PARA A TELA DE COMPLEMENTO DE CADASTRO
                        TelaInicial tela = new TelaInicial();
                        tela.IniciarCadastroComp();
                    //}
                }
                catch (Exception ex)
                {
                    Alert("Erro de conexão com o banco de dados!",FormAlert.enmType.Error);
                    //MessageBox.Show($"Erro: {ex.Message}", "ERRO!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

    }
    
}

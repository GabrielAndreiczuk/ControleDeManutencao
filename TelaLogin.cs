using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Projeto_TCC
{
    public partial class TelaLogin : Form
    {
        public TelaLogin()
        {
            InitializeComponent();            
        }

        private void TelaLogin_Load(object sender, EventArgs e)
        {
            textBox1.Focus();
        }

        //MÉTODO QUE INSTANCIA E CHAMA NOTIFICAÇÕES PERSONALIZADAS
        public void Alert(string msg, FormAlert.enmType type)
        {
            FormAlert frm = new FormAlert();
            frm.showAlert(msg, type);
        }
        //MÉTODO QUE ALTERA A COR DO TEXTO DA LABEL CADASTRO
        private void lblCadastro_MouseHover(object sender, EventArgs e)
        {
            this.lblCadastro.Font = new Font(this.lblCadastro.Font, FontStyle.Italic | FontStyle.Bold);
            this.lblCadastro.ForeColor = Color.Yellow;
        }

        private void lblCadastro_MouseLeave(object sender, EventArgs e)
        {
            this.lblCadastro.Font = new Font(this.lblCadastro.Font, FontStyle.Italic);
            this.lblCadastro.ForeColor = Color.White;
        }
        //MÉTODOS QUE DIRECIONA PARA A PÁGINA DE CADASTRO
        private void lblCadastro_Click(object sender, EventArgs e)
        {
            TelaInicial inicial = new TelaInicial();
            inicial.IniciarCadastro();
        }

        //MÉTODO DO BOTÃO DE LOGIN
        private void btnLogin_Click(object sender, EventArgs e)
        {
            //VERIFICA SE TODOS OS CAMPOS ESTÃO PREENCHIDOS
            if (textBox1.Text == "" || textBox2.Text == "")
            {
                Alert("Por favor, preencha todos os campos.", FormAlert.enmType.Warning);             
                return; // Sai do método para impedir a execução de código adicional
            }

            string connectionString = "Server=localhost;Uid=root;Database=projeto;Port=3306;";

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    // DEFINE A CONSULTA SQL PARA PEGAR TODOS OS REGISTROS DA TABELA 'CLIENTES'
                    string selectQuery = "SELECT * FROM view_funcionario";

                    using (MySqlCommand command = new MySqlCommand(selectQuery, connection))
                    {
                        // EXECUTA A CONSULTA E OBTÉM UM MySqlDataReader PARA ACESSAR OS DADOS RETORNADOS
                        using (MySqlDataReader reader = command.ExecuteReader())
                        {
                            bool login = false;
                            int id = 0;
                            string nome = "";
                            string email = "", setor = "", cargo = "", contato = "";
                            string senha;

                            // PERCORRE CADA LINHA DE RESULTADOS RETORNADA PELA CONSULTA
                            while (reader.Read())
                            {
                                // LÊ O VALOR DAS COLUNAS 'NOME' E 'EMAIL' DA LINHA ATUAL
                                id = (int) reader["ID_Funcionario"];
                                nome = reader["Nome"].ToString();
                                email = reader["Email"].ToString();
                                senha = reader["Senha"].ToString();
                                setor = reader["Setor"].ToString();
                                cargo = reader["Cargo"].ToString();
                                contato = reader["Contato"].ToString();

                                if (email == textBox1.Text && senha == textBox2.Text)
                                {
                                    login = true;
                                    break;
                                }
                            }
                            if(login == true)
                            {
                                //DEFINE ATRIBUTOS DO USUÁRIO LOGADO NO SISTEMA
                                UsuarioSessao.UsuarioAtual = new Usuario();
                                UsuarioSessao.UsuarioAtual.Nome = nome;
                                UsuarioSessao.UsuarioAtual.ID = id;                                
                                UsuarioSessao.UsuarioAtual.Email = email;                                
                                UsuarioSessao.UsuarioAtual.Setor = setor;                                
                                UsuarioSessao.UsuarioAtual.Cargo = cargo;                                
                                UsuarioSessao.UsuarioAtual.Contato = contato;                                

                                TelaInicial tela = new TelaInicial();
                                tela.IniciarMenu();
                                Alert("Login efetuado com sucesso!", FormAlert.enmType.Success);
                            }
                            else
                            {
                                lblSenha.Show();
                                lblSenha.Text = "Usuário ou senha incorreta!";
                            }                            
                        }
                    }
                }
                catch (Exception ex)
                {
                    Alert("Erro de conexão com o banco de dados!", FormAlert.enmType.Error);
                    //MessageBox.Show($"Erro: {ex.Message}", "ERRO!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }        
    }
}

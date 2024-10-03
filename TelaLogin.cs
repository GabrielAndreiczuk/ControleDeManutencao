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

namespace Projeto_TCC
{
    public partial class TelaLogin : Form
    {
        public TelaLogin()
        {
            InitializeComponent();
        }

        //MÉTODO QUE INSTANCIA E CHAMA NOTIFICAÇÕES PERSONALIZADAS
        public void Alert(string msg, FormAlert.enmType type)
        {
            FormAlert frm = new FormAlert();
            frm.showAlert(msg, type);
        }

        private void label7_MouseHover(object sender, EventArgs e)
        {
            this.label7.Font = new Font(this.label7.Font, FontStyle.Italic | FontStyle.Bold);
            this.label7.ForeColor = Color.Yellow;
        }

        private void label7_MouseLeave(object sender, EventArgs e)
        {
            this.label7.Font = new Font(this.label7.Font, FontStyle.Italic);
            this.label7.ForeColor = Color.White;
        }
        private void label7_Click(object sender, EventArgs e)
        {
            TelaCadastro form = new TelaCadastro();
            this.Hide();
            form.Closed += (s, args) => this.Close();
            form.Show();
        }

        private void rjButton2_Click(object sender, EventArgs e)
        {
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
                    string selectQuery = "SELECT * FROM funcionario";

                    using (MySqlCommand command = new MySqlCommand(selectQuery, connection))
                    {
                        // EXECUTA A CONSULTA E OBTÉM UM MySqlDataReader PARA ACESSAR OS DADOS RETORNADOS
                        using (MySqlDataReader reader = command.ExecuteReader())
                        {
                            bool login = false;
                            int id = 0;
                            string nome = "";
                            string email;
                            string senha;
                            // PERCORRE CADA LINHA DE RESULTADOS RETORNADA PELA CONSULTA
                            while (reader.Read())
                            {
                                // LÊ O VALOR DAS COLUNAS 'NOME' E 'EMAIL' DA LINHA ATUAL
                                id = (int) reader["ID_Funcionario"];
                                nome = reader["Nome"].ToString();
                                email = reader["Email"].ToString();
                                senha = reader["Senha"].ToString();

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


                                Alert("Login efetuado com sucesso!", FormAlert.enmType.Success);

                                TelaMenu form = new TelaMenu();
                                this.Hide();
                                form.Closed += (s, args) => this.Close();
                                form.Show();
                            }
                            else
                            {
                                label8.Show();
                                label8.Text = "Usuário ou senha incorreta!";
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

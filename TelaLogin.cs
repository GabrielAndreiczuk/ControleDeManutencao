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
                MessageBox.Show("Por favor, preencha todos os campos.", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);             
                //label8.Text = "Por favor, preencha todos os campos.";
                //label8.Show();
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
                            // PERCORRE CADA LINHA DE RESULTADOS RETORNADA PELA CONSULTA
                            while (reader.Read())
                            {
                                // LÊ O VALOR DAS COLUNAS 'NOME' E 'EMAIL' DA LINHA ATUAL
                                string id = reader["ID_Funcionario"].ToString();
                                string nome = reader["Nome"].ToString();
                                string email = reader["Email"].ToString();
                                string senha = reader["Senha"].ToString();

                                if (email == textBox1.Text && senha == textBox2.Text)
                                {
                                    login = true;
                                    break;
                                }
                            }
                            if(login == true)
                            {
                                MessageBox.Show("Login Efetuado Com sucesso!", "Parabéns!", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                    MessageBox.Show($"Erro: {ex.Message}", "ERRO!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}

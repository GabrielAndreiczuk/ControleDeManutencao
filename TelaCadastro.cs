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
        //VALIDAÇÃO NOME DO USUÁRIO
        private void validacaoNome(object sender, KeyPressEventArgs e)
        {          
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && (e.KeyChar != ' '))
            {
                e.Handled = true;
                MessageBox.Show("Este campo aceita somente letras.", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        //VALIDAÇÃO EMAIL DO USUÁRIO
        private void validacaoEmail(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar == '@') && ((sender as TextBox).Text.IndexOf('@') > -1))
            {
                e.Handled = true;
                MessageBox.Show("Este campo aceita somente um arroba.", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        //EVENTOS DE HOOVER LINK PARA LOGIN
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

        //VOLTA PARA A PÁGINA DE LOGIN
        private void label7_Click(object sender, EventArgs e)
        {
            TelaLogin form = new TelaLogin();
            this.Hide();
            form.Closed += (s, args) => this.Close();
            form.Show();
        }

        //VERIFICAÇÃO DE COMPATIBILIDADE DAS SENHAS
        private void checkPassword(object sender, EventArgs e)
        {
            if (textBox4.Text != "")
            {
                string passowrd = textBox3.Text;
                if (textBox4.Text != passowrd)
                {
                    label8.Show();
                    label8.ForeColor = Color.Yellow;
                    label8.Text = "As senhas não coincidem!";
                }
                else
                {
                    label8.Show();
                    label8.ForeColor = Color.Lime;
                    label8.Text = "Ótimo! As senhas estão iguais.";

                }
            }
        }

        //PROGRAMAÇÃO DO BOTÃO DE CADASTRO
        private void rjButton1_Click(object sender, EventArgs e)
        {
            //VERIFICAR SE TODOS OS CAMPOS ESTÃO PREENCHIDOS
            if(textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "" || textBox4.Text == "")
            {
                MessageBox.Show("Por favor, preencha todos os campos.", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return; // Sai do método para impedir a execução de código adicional
            }

            //VERFICAR SE O EMAIL ESTA NO FORMATO CORRETO
            string TesteEmail = textBox2.Text;
            string pattern = @"^[^@\s]+@[^@\s]+\.(com)$";
            Regex regex = new Regex(pattern, RegexOptions.IgnoreCase);
            if (!regex.IsMatch(TesteEmail))
            {
                MessageBox.Show("Email no formato incorreto!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
                
            }
            
            //VERIFICAR SE AS SENHAS SÃO IGUAIS
            if(textBox3.Text != textBox4.Text)
            {
                MessageBox.Show("Senhas não coincidem!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
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

                    string nome = textBox1.Text;
                    string email = textBox2.Text;                
                    string senha = textBox3.Text;

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

                        //DIRECIONA PARA A TELA DE COMPLEMENTO DE CADASTRO
                        TelaCadastroComp form = new TelaCadastroComp();
                        form.Closed += (s, args) => this.Close();
                        form.Show();                       
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

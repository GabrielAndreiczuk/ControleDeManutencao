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
        private void validacaoNome(object sender, KeyPressEventArgs e)
        {          
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && (e.KeyChar != ' '))
            {
                e.Handled = true;
                MessageBox.Show("Este campo aceita somente letras.", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
        private void validacaoEmail(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar == '@') && ((sender as TextBox).Text.IndexOf('@') > -1))
            {
                e.Handled = true;
                MessageBox.Show("Este campo aceita somente um arroba.", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        //EVENTOS DE TRANSFORMAÇÃO DE TEXTO
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
        //LEVA PARA A PÁGINA DE LOGIN
        private void label7_Click(object sender, EventArgs e)
        {
            TelaLogin form = new TelaLogin();
            this.Hide();
            form.Closed += (s, args) => this.Close();
            form.Show();
        }

        //VERIFICA SE AS SENHAS COINCIDEM
        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            string passowrd = textBox3.Text;
            if(textBox4.Text != passowrd)
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

        //PROGRAMAÇÃO DO BOTÃO DE CADASTRO
        private void rjButton1_Click(object sender, EventArgs e)
        {
            //VERIFICAR SE AS LABELS ESTÃO PREENCHIDAS
            bool allTextBoxesFilled = true;

            // VERIFICAR SE AS TEXTBOXES ESTÃO PREENCHIDAS
            if(textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "" || textBox4.Text == "")
            {
                MessageBox.Show("Por favor, preencha todos os campos.", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return; // Sai do método para impedir a execução de código adicional
            }
            /*
            foreach (Control controle in this.Controls)
            {
                if (controle is TextBox textBox)
                {
                    // Verifica se o TextBox está vazio
                    if (string.IsNullOrEmpty(textBox.Text))
                    {
                        allTextBoxesFilled = false;
                        break; // Sai do loop ao encontrar a primeira TextBox vazia
                    }
                }
            }

            // Se alguma TextBox estiver vazia, exibe a mensagem de alerta
            if (!allTextBoxesFilled)
            {
                MessageBox.Show("Por favor, preencha todos os campos.", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return; // Sai do método para impedir a execução de código adicional
            }*/

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

                    //FAZER VERIFICAÇÃO DE SENHA                  
                    string senha = textBox3.Text;


                    //DEFINE A CONSULTA SQL PARA INSERIR UM NOVO CLIENTE NA TABELA PASSANDO PARÂMETROS
                    string insertQuery = "INSERT INTO funcionario (Nome, Email, Senha) VALUES (@Nome, @Email, AES_ENCRYPT('@Senha','chave'))";

                    //CRIA O COMANDO SQL COM A CONSULTA E A CONEXÃO
                    using (MySqlCommand command = new MySqlCommand(insertQuery, connection))
                    {
                        //ADICIONA OS DADOS LIDOS COMO PARÂMETROS PARA CONSULTA
                        command.Parameters.AddWithValue("@Nome", nome);
                        command.Parameters.AddWithValue("@Email", email);
                        command.Parameters.AddWithValue("@Senha", senha);

                        //EXECUTA O COMANDO PARA INSERIR OS DADOS NO BANCO
                        command.ExecuteNonQuery();  //USADO PARA COMANDOS QUE NÃO RETORNAM RESULTADOS
                        /*
                        ComplementoCadastro form = new ComplementoCadastro();
                        this.Hide();
                        form.Closed += (s, args) => this.Close();
                        form.Show();
                        */
                        MessageBox.Show("Usuário cadastrado com sucesso!","Parabéns!", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        //label9.Text = "Cliente inserido com sucesso!";
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Erro: {ex.Message}", "ERRO!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    //label9.Text = ($"Erro: {ex.Message}");
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string email = textBox2.Text;
            string pattern = @"^[^@\s]+@[^@\s]+\.(com)$";
            Regex regex = new Regex(pattern, RegexOptions.IgnoreCase);
            if(regex.IsMatch(email))
            {
                label8.Show();
                label8.Text = "Email correto";
            }
            else
            {
                label8.Show();
                label8.Text = "Email no formato incorreto";
            }
        }
    }
    
}

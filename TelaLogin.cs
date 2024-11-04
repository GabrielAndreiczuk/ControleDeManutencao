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

            this.Text = string.Empty;
            this.ControlBox = false;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
        }
        //CÓDIGO PARA MOVIMENTAÇÃO E REDIMENSIONAMENTO DA TELA
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void TelaLogin_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        //MÉTODO QUE INSTANCIA E CHAMA NOTIFICAÇÕES PERSONALIZADAS
        public void Alert(string msg, FormAlert.enmType type)
        {
            FormAlert frm = new FormAlert();
            frm.showAlert(msg, type);
        }

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
        private void lblCadastro_Click(object sender, EventArgs e)
        {
            TelaCadastro form = new TelaCadastro();
            this.Hide();
            form.Closed += (s, args) => this.Close();
            form.Show();
        }

        private void btnLogin_Click(object sender, EventArgs e)
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

        //EVENTOS BOTÕES CONTROLES DE TELA - FECHAR
        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
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
            pibFechar.BackColor = Color.FromArgb(0,51,102);
            pibMaximizar.BackColor = Color.FromArgb(0,51,102);
            pibMinimizar.BackColor = Color.FromArgb(0, 51, 102);
            labelClose.BackColor = Color.FromArgb(0, 51, 102);
            lblMaximizar.BackColor = Color.FromArgb(0, 51, 102);
            lblMinimizar.BackColor = Color.FromArgb(0, 51, 102);
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }
    }
}

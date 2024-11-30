using Org.BouncyCastle.Tls;
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

namespace Projeto_TCC
{
    public partial class TelaInicial : Form
    {
        public TelaInicial()
        {
            InitializeComponent();

            this.Text = string.Empty;
            this.ControlBox = false;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
        }
        private void TelaInicial_Load(object sender, EventArgs e)
        {
            IniciarLogin();
        }

        //CÓDIGO PARA MOVIMENTAÇÃO E REDIMENSIONAMENTO DA TELA
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        //MÉTODO QUE PASSA A INFORMAÇÃO DE MOVIMENTO DA TELA
        private void TelaInicial_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        //MÉTODO QUE INICIAR A TELA DE LOGIN NA TELA INICIAL
        public void IniciarLogin()
        {
            try
            {
                TelaInicial tela = Application.OpenForms["TelaInicial"] as TelaInicial;
                tela.panelInfo.Controls.Clear();

                TelaLogin login = new TelaLogin();
                login.TopLevel = false;
                login.Dock = DockStyle.Fill;
                login.FormBorderStyle = FormBorderStyle.None;

                tela.panelInfo.Controls.Add(login);
                login.Show();

            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex}");
            }
            
        }
        public void IniciarCadastro()
        {
            try
            {
                TelaInicial tela = Application.OpenForms["TelaInicial"] as TelaInicial;
                tela.panelInfo.Controls.Clear();

                TelaCadastro cadastro = new TelaCadastro();
                cadastro.TopLevel = false;
                cadastro.Dock = DockStyle.Fill;
                cadastro.FormBorderStyle = FormBorderStyle.None;

                tela.panelInfo.Controls.Add(cadastro);
                cadastro.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex}");
            }
        }
        public void IniciarCadastroComp()
        {
            try
            {
                TelaInicial tela = Application.OpenForms["TelaInicial"] as TelaInicial;
                tela.panelInfo.Controls.Clear();

                TelaCadastroComp cadastro = new TelaCadastroComp();
                cadastro.TopLevel = false;
                cadastro.Dock = DockStyle.Fill;
                cadastro.FormBorderStyle = FormBorderStyle.None;

                tela.panelInfo.Controls.Add(cadastro);
                cadastro.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex}");
            }
        }
        public void IniciarMenu()
        {         
            try
            {
                TelaInicial tela = Application.OpenForms["TelaInicial"] as TelaInicial;
                tela.panelInfo.Controls.Clear();

                TelaMenu menu = new TelaMenu();
                tela.Hide();
                menu.Closed += (s, args) => tela.Close();
                menu.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex}");
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
            pibMaximizar.BackColor = Color.FromArgb(0, 20, 50);
            lblMaximizar.BackColor = Color.FromArgb(0, 20, 50);
        }
        //HOOVER CONTROLES DE TELA - MINIMIZAR
        private void pibMinimizar_MouseHover(object sender, EventArgs e)
        {
            pibMinimizar.BackColor = Color.FromArgb(0, 20, 50);
            lblMinimizar.BackColor = Color.FromArgb(0, 20, 50);
        }
        //HOOVER CONTROLES DE TELA - RESET DO ESTILO
        private void ResetBackground_MouseLeave(object sender, EventArgs e)
        {
            pibFechar.BackColor = Color.FromArgb(0, 36, 72);
            pibMaximizar.BackColor = Color.FromArgb(0, 36, 72);
            pibMinimizar.BackColor = Color.FromArgb(0, 36, 72);
            labelClose.BackColor = Color.FromArgb(0, 36, 72);
            lblMaximizar.BackColor = Color.FromArgb(0, 36, 72);
            lblMinimizar.BackColor = Color.FromArgb(0, 36, 72);
        }

        
    }
}

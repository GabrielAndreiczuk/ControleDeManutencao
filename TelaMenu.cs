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
    public partial class TelaMenu : Form
    {
        //MÉTODO CONSTRUTOR
        public TelaMenu()
        {
            InitializeComponent();
            btnMenu_Click(btnMenu, EventArgs.Empty);
            try
            {
                lblTitulo.Text = $"Boa noite {UsuarioSessao.UsuarioAtual.Nome}";
            }
            catch (Exception ex)
            {
                lblTitulo.Text = $"Boa noite";
            }
            this.Text = string.Empty;
            this.ControlBox = false;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
        }

        //CÓDIGO PARA MOVIMENTAÇÃO E REDIMENSIONAMENTO DA TELA
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        //EVENTO PARA MOVIMENTAÇÃO DA TELA
        private void Panel2_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        //DECLARAÇÃO DO BOTÃO ATIVO
        private Button currentButton;
        //CÓDIGO PARA DETERMINAÇÃO DO BOTÃO ATIVO
        public void ActiveButton(object btnSender)
        {
            if (btnSender != null)
            {
                if (currentButton != (Button)btnSender)
                {
                    DisableButton((Button)btnSender);
                    currentButton = (Button)btnSender;
                    currentButton.BackColor = Color.FromArgb(0, 51, 102);
                    //currentButton.BackColor = Color.FromArgb(255, 165, 0);
                }
            }
        }
        //CÓDIGO PARA DESATIVAR BOTÃO ATUAL
        private void DisableButton(object btnSender)
        {
            foreach(Control previusBtn in this.panel1.Controls)
            { 
                if (previusBtn.GetType() == typeof(Button))
                {
                    previusBtn.BackColor = Color.FromArgb(54, 124, 221);
                }
            }
        }

        //EVENTOS DE CLIQUE BOTÕES LATERAIS
        private void btnMenu_Click(object sender, EventArgs e)
        {
            ActiveButton(sender);
            lblTittle.Text = "Menu Inicial";
        }
        private void btnIndicativos_Click(object sender, EventArgs e)
        {
            ActiveButton(sender);
            lblTittle.Text = "Consulta Indicativos";

            TelaMenu menu = Application.OpenForms["TelaMenu"] as TelaMenu;
            menu.panelMenu.Controls.Clear();

            TelaIndicativos indicativos = new TelaIndicativos ();
            indicativos.TopLevel = false;
            indicativos.Dock = DockStyle.Fill;
            indicativos.FormBorderStyle = FormBorderStyle.None;

            menu.panelMenu.Controls.Add(indicativos);
            indicativos.Show();
        }
        private void btnOrdem_Click(object sender, EventArgs e)
        {
            ActiveButton(sender);
            lblTittle.Text = "Nova Ordem";

            TelaMenu menu = Application.OpenForms["TelaMenu"] as TelaMenu;
            menu.panelMenu.Controls.Clear();

            TelaOrdem ordem = new TelaOrdem();
            ordem.TopLevel = false;
            ordem.Dock = DockStyle.Fill;
            ordem.FormBorderStyle = FormBorderStyle.None;

            menu.panelMenu.Controls.Add(ordem);
            ordem.Show();
        }
        private void btnHistorico_Click(object sender, EventArgs e)
        {
            ActiveButton(sender);
            lblTittle.Text = "Consulta Histórico";

            TelaMenu menu = Application.OpenForms["TelaMenu"] as TelaMenu;
            menu.panelMenu.Controls.Clear();

            TelaHistorico historico = new TelaHistorico();
            historico.TopLevel = false;
            historico.Dock = DockStyle.Fill;
            historico.FormBorderStyle = FormBorderStyle.None;

            menu.panelMenu.Controls.Add(historico);
            historico.Show();
        }
        private void btnConfig_Click(object sender, EventArgs e)
        {
            ActiveButton(sender);
            lblTittle.Text = "Configurações";
        }
        public void btnOrdensAberto_Click(object sender, EventArgs e)
        {
            ActiveButton(sender);
            lblTittle.Text = "Ordens em Aberto";

            TelaMenu menu = Application.OpenForms["TelaMenu"] as TelaMenu;
            menu.panelMenu.Controls.Clear();

            TelaOrdensAberto emAberto = new TelaOrdensAberto();
            emAberto.TopLevel = false;
            emAberto.Dock = DockStyle.Fill;
            emAberto.FormBorderStyle = FormBorderStyle.None;

            menu.panelMenu.Controls.Add(emAberto);
            emAberto.Show();
        }

        //RECOLHER MENU LATERAL
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (panel1.Width == 300)
            {
                lblTitulo.Text = "";
                btnConfig.Text = "";
                panel1.Width = 85;

            }
            else
            {
                lblTitulo.Text = "Boa noite";
                btnConfig.Text = "      Configurações";
                panel1.Width = 300;
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
            pibFechar.BackColor = Color.FromArgb(54, 124, 221);
            pibMaximizar.BackColor = Color.FromArgb(54, 124, 221);
            pibMinimizar.BackColor = Color.FromArgb(54, 124, 221);
            labelClose.BackColor = Color.FromArgb(54, 124, 221);
            lblMaximizar.BackColor = Color.FromArgb(54, 124, 221);
            lblMinimizar.BackColor = Color.FromArgb(54, 124, 221);
        }

        public void IniciarConclusaoOrdem(int ID)
        {
            TelaMenu menu = Application.OpenForms["TelaMenu"] as TelaMenu;
            menu.panelMenu.Controls.Clear();
            menu.lblTittle.Text = "Conclusão de Ordem";

            TelaConclusao conclusao = new TelaConclusao(ID);
            conclusao.TopLevel = false;
            conclusao.Dock = DockStyle.Fill;
            conclusao.FormBorderStyle = FormBorderStyle.None;

            menu.panelMenu.Controls.Add(conclusao);
            conclusao.Show();
        }

    }//FECHAR CLASSE
}//FECHAR NAMESPACE

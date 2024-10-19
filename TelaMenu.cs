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
        public TelaMenu()
        {
            InitializeComponent();
            btnMenu_Click(btnMenu,EventArgs.Empty);
            //label1.Text = $"Boa noite {UsuarioSessao.UsuarioAtual.Nome}";

            this.Text = string.Empty;
            this.ControlBox = false;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private Button currentButton;
        
        public void ActiveButton(object btnSender)
        {
            if (btnSender != null)
            {
                if (currentButton != (Button)btnSender)
                {
                    DisableButton((Button)btnSender);
                    currentButton = (Button)btnSender;
                    currentButton.BackColor = Color.FromArgb(54, 124, 221);
                    //currentButton.BackColor = Color.FromArgb(255, 165, 0);
                }
            }
        }
        private void DisableButton(object btnSender)
        {
            foreach(Control previusBtn in this.panel1.Controls)
            { 
                if (previusBtn.GetType() == typeof(Button))
                {
                    previusBtn.BackColor = Color.FromArgb(0, 51, 102);
                }
            }
        }

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
            lblTittle.Text = "Abrir Ordem de Serviço";

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

        private void btnOrdensAberto_Click(object sender, EventArgs e)
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

        private void Panel2_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMaximize_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
                this.WindowState = FormWindowState.Maximized;
            else
                this.WindowState = FormWindowState.Normal;
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
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
        }

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

            TelaIndicativos historico = new TelaIndicativos ();
            historico.TopLevel = false;
            historico.Dock = DockStyle.Fill;
            historico.FormBorderStyle = FormBorderStyle.None;

            menu.panelMenu.Controls.Add(historico);
            historico.Show();
        }
        private void btnOrdem_Click(object sender, EventArgs e)
        {
            ActiveButton(sender);
            lblTittle.Text = "Abrir Ordem de Serviço";
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
    }
}

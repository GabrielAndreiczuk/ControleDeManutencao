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
    public partial class TelaInicial : Form
    {
        public TelaInicial()
        {
            InitializeComponent();
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
            pibFechar.BackColor = Color.FromArgb(0, 51, 102);
            pibMaximizar.BackColor = Color.FromArgb(0, 51, 102);
            pibMinimizar.BackColor = Color.FromArgb(0, 51, 102);
            labelClose.BackColor = Color.FromArgb(0, 51, 102);
            lblMaximizar.BackColor = Color.FromArgb(0, 51, 102);
            lblMinimizar.BackColor = Color.FromArgb(0, 51, 102);
        }

    }
}

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
    public partial class TelaIndicativos : Form
    {
        public TelaIndicativos()
        {
            InitializeComponent();
        }

        private void TelaIndicativos_Load(object sender, EventArgs e)
        {
            pibFiltrar_Click(sender, EventArgs.Empty);
        }

        private void pibFiltrar_Click(object sender, EventArgs e)
        {
            if (pnlFiltros.Height == 150)
            {
                foreach (Control control in pnlFiltros.Controls)
                {
                    if (!(control is PictureBox) && (control != lblLine))
                    {
                        control.Visible = false;
                    }
                }
                pnlFiltros.Height = 52;
            }
            else
            {
                foreach (Control control in pnlFiltros.Controls)
                {
                    if (!(control is Button))
                    {
                        control.Visible = true;
                    }
                }
                pnlFiltros.Height = 150;
            }
            
        }
    }
}

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
            timer1_Tick(this, EventArgs.Empty);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime data = DateTime.Now;
            lblData.Text = data.ToString("HH:mm:ss - dd/MM/yyyy");
        }
    }
}

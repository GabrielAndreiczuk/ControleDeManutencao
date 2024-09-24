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
            button1_Click(button1,EventArgs.Empty);
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

        private void button1_Click(object sender, EventArgs e)
        {
            ActiveButton(sender);
        }
        private void button2_Click(object sender, EventArgs e)
        {
            ActiveButton(sender);
        }
        private void button3_Click(object sender, EventArgs e)
        {
            ActiveButton(sender);
        }
        private void button4_Click(object sender, EventArgs e)
        {
            ActiveButton(sender);
        }
        private void button5_Click(object sender, EventArgs e)
        {
            ActiveButton(sender);
        }
    }
}

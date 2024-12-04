using Org.BouncyCastle.Asn1.Cmp;
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
    public partial class TelaConfiguracao : Form
    {
        public TelaConfiguracao()
        {
            InitializeComponent();

            CarregarDados();
        }

        private void CarregarDados()
        {
            lblUsuario.Text = UsuarioSessao.UsuarioAtual.Nome;
            lblID.Text = $"ID: {UsuarioSessao.UsuarioAtual.ID}";
            txtEmail.Text = UsuarioSessao.UsuarioAtual.Email;
            lblSetorUsuario.Text = UsuarioSessao.UsuarioAtual.Setor;
        }

        private void pibEmail_Click(object sender, EventArgs e)
        {
            txtEmail.ReadOnly = false;
            txtEmail.Focus();

            btnConfirmar.Visible = true;
        }

        private void pibCargo_Click(object sender, EventArgs e)
        {
            lblCargo.Visible = true;
            cmbCargo.Visible = true;
            lblCargoTitulo.Visible = true;

            btnConfirmar.Visible = true;
        }

        private void pibSetor_Click(object sender, EventArgs e)
        {
            lblSetor.Visible = true;
            cmbSetor.Visible = true;
            lblSetorTitulo.Visible = true;

            btnConfirmar.Visible = true;
        }
    }
}

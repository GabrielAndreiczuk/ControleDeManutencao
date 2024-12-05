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
            lblCargoUsuario.Text = UsuarioSessao.UsuarioAtual.Cargo;
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

        private void pibContato_Click(object sender, EventArgs e)
        {
            txtContato.ReadOnly = false;
            txtContato.Focus();

            btnConfirmar.Visible = true;
        }

        private void ContactFormatting(object sender, EventArgs e)
        {
            //Remove qualquer formatação existente
            string numero = txtContato.Text.Replace("(", "").Replace(")", "").Replace("-", "").Replace(" ", "");
            if (numero.Length > 2)
            {
                numero = "(" + numero.Substring(0, 2) + ") " + numero.Substring(2);
            }
            if (numero.Length > 10)
            {
                numero = numero.Substring(0, 10) + "-" + numero.Substring(10);
            }
            txtContato.Text = numero;
            txtContato.SelectionStart = txtContato.Text.Length;
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            TelaMenu menu = new TelaMenu();
            menu.Logout();
        }
    }
}

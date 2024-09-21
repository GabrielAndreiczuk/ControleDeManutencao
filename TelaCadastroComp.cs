﻿using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_TCC
{
    public partial class TelaCadastroComp : Form
    {
        private string connectionString = "Server=localhost;Uid=root;Database=projeto;Port=3306;";
        private int borderSize = 0;
        private int borderRadius = 50;
        private Color borderColor = Color.White;
        
        //MÉTODO CONSTRUTOR
        public TelaCadastroComp()
        {
            InitializeComponent();

            this.FormBorderStyle = FormBorderStyle.None;
            this.BackColor = Color.FromArgb(0, 51, 102);
            this.ForeColor = Color.White;
            this.Size = new System.Drawing.Size(800, 650);
            this.StartPosition = FormStartPosition.CenterScreen;

            PreencherComboBox();
        }

        //MÉTODO QUE REALIZA O ARREDONDAMENTO DA BORDA
        private GraphicsPath GetFigurePath(RectangleF rect, float radius)
        {
            GraphicsPath path = new GraphicsPath();
            path.StartFigure();
            path.AddArc(rect.X, rect.Y, radius, radius, 180, 90);
            path.AddArc(rect.Width - radius, rect.Y, radius, radius, 270, 90);
            path.AddArc(rect.Width - radius, rect.Height - radius, radius, radius, 0, 90);
            path.AddArc(rect.X, rect.Height - radius, radius, radius, 90, 90);
            path.CloseFigure();

            return path;
        }

        //MÉTODO PARA PREENCHER E RENDERIZAR A FIGURA COM MAIOR QUALIDADE
        protected override void OnPaint(PaintEventArgs pavent)
        {
            base.OnPaint(pavent);
            pavent.Graphics.SmoothingMode = SmoothingMode.AntiAlias;

            RectangleF rectSurface = new RectangleF(0, 0, this.Width, this.Height);
            RectangleF rectBorder = new RectangleF(1, 1, this.Width - 0.8F, this.Height - 1);

            if (borderRadius > 2)//rounded button
            {
                using (GraphicsPath pathSurface = GetFigurePath(rectSurface, borderRadius))
                using (GraphicsPath pathBorder = GetFigurePath(rectBorder, borderRadius - 1F))
                using (Pen penSurface = new Pen(this.BackColor, 2))
                using (Pen penBorder = new Pen(borderColor, borderSize))
                {
                    penBorder.Alignment = PenAlignment.Inset;
                    //Button surface
                    this.Region = new Region(pathSurface);
                    //Draw surface border for HD result
                    pavent.Graphics.DrawPath(penSurface, pathSurface);

                    //Button border
                    if (borderSize >= 1)
                    {
                        pavent.Graphics.DrawPath(penBorder, pathBorder);
                    }
                }
            }
            else//Normal button
            {
                //button surface
                this.Region = new Region(rectSurface);
                //button border
                if (borderSize >= 1)
                {
                    using (Pen penBorder = new Pen(borderColor, borderSize))
                    {
                        penBorder.Alignment = PenAlignment.Inset;
                        pavent.Graphics.DrawRectangle(penBorder, 0, 0, this.Width - 1, this.Height - 1);
                    }

                }
            }

        }

        //REDIMENSIONA A TELA
        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            this.Invalidate(); // Redesenha o formulário quando ele for redimensionado
        }

        //MÉTODO QUE INSTANCIA E CHAMA NOTIFICAÇÕES PERSONALIZADAS
        public void Alert(string msg, FormAlert.enmType type)
        {
            FormAlert frm = new FormAlert();
            frm.showAlert(msg, type);
            txtContato.Focus();
        }

        //MÉTODO PARA PREENCHER AS COMBOBOX SETOR E CARGO
        private void PreencherComboBox()
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    //PREENCHER COMBOBOX SETOR
                    string query = "SELECT Nome FROM setor";

                    MySqlDataAdapter dataAdapter = new MySqlDataAdapter(query, connection);
                    DataTable dataTable = new DataTable();
                    dataAdapter.Fill(dataTable);

                    DataRow row = dataTable.NewRow();
                    row["Nome"] = "Escolha seu Setor!";
                    dataTable.Rows.InsertAt(row, 0);

                    cmbSetor.DataSource = dataTable;
                    cmbSetor.DisplayMember = "Nome";
                    //cmbSetor.ValueMember = "ID_Ferramenta";
                    cmbSetor.SelectedIndex = 0;

                    //PREENCHER COMBOBOX CARGO
                    query = "SELECT Nome FROM cargo";

                    MySqlDataAdapter dataAdapterCargo = new MySqlDataAdapter(query, connection);
                    DataTable dataTableCargo = new DataTable();
                    dataAdapterCargo.Fill(dataTableCargo);

                    DataRow rowCargo = dataTableCargo.NewRow();
                    rowCargo["Nome"] = "Escolha seu Cargo!";
                    dataTableCargo.Rows.InsertAt(rowCargo, 0);

                    cmbCargo.DataSource = dataTableCargo;
                    cmbCargo.DisplayMember = "Nome";
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao preencher a ComboBox: " + ex.Message);
                }
            }
        }

        //FORMATAÇÃO CAMPO DE CONTATO
        private void ContactFormatting(object sender, EventArgs e)
        {
            //Remove qualquer formatação existente
            string numero = txtContato.Text.Replace("(", "").Replace(")", "").Replace("-", "").Replace(" ","");
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
        //VALIDAÇÃO CARACTERES CAMPO DE CONTATO
        private void onlyDigit(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                //MessageBox.Show("Este campo aceita somente números.", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                Alert("Este campo aceita somente números!", FormAlert.enmType.Info);
            }
            string numero = txtContato.Text;
            if (!char.IsControl(e.KeyChar) && numero.Length >= 15)
            {
                e.Handled = true;
            }
        }

        //AÇÃO BOTÃO FINALIZAR CADASTRO
        private void rjButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

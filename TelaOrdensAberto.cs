using MySqlConnector;
using Mysqlx.Crud;
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
    public partial class TelaOrdensAberto : Form
    {
        public TelaOrdensAberto()
        {
            InitializeComponent();
            AdicionarComponentes();
        }
        string id = "", solicitante = "", abertura = "", setor = "", maquina = "", descricao = "", status = "";

        private void AdicionarComponentes()
        {
            string connectionString = "Server=localhost;Uid=root;Database=projeto;Port=3306";
            List<string> ordens = new List<string>();
            

            using(MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string selectQuery = "SELECT * from view_abertura_ordem";
                    
                    int yOffset = 50;

                    using (MySqlCommand command = new MySqlCommand(selectQuery, connection))
                    {
                        using (MySqlDataReader reader = command.ExecuteReader())
                        {

                            while (reader.Read())
                            {
                                
                                id = reader["ID"].ToString();
                                solicitante = reader["Solicitante"].ToString();
                                DateTime dataHora = Convert.ToDateTime(reader["abertura"]);
                                abertura = dataHora.ToString("dd/MM/yyyy");
                                setor = reader["Setor"].ToString();
                                maquina = reader["Máquina"].ToString();
                                descricao = reader["Descrição"].ToString();
                                status = reader["Status"].ToString();

                                //string consulta = ($"{id} {solicitante} {abertura} {setor} {maquina} {descricao} {status}");

                                //ordens.Add(consulta);
                                
                                yOffset = AdicionarColunas(yOffset);
                            }
                        }
                    } 
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }                                   
            }
        }
        
        private int AdicionarColunas(int yOffset)
        {
            Label lblID = new Label()
            {
                Text = $"{id}",
                TextAlign = ContentAlignment.MiddleCenter,
                Location = new System.Drawing.Point(0, yOffset),                
                Size = new System.Drawing.Size(100,40),
            };
            this.panID.Controls.Add(lblID);

            Label lblSolicitante = new Label()
            {
                Text = $"{solicitante}",
                TextAlign = ContentAlignment.MiddleLeft,
                Location = new System.Drawing.Point(0, yOffset),
                MinimumSize = new System.Drawing.Size(100, 40),
                AutoSize = true,
                Padding = new Padding(10)
            };
            this.panSolicitante.Controls.Add(lblSolicitante);

            Label lblAbertura = new Label()
            {
                Text = $"{abertura}",
                TextAlign = ContentAlignment.MiddleCenter,
                Location = new System.Drawing.Point(0, yOffset),
                Size = new System.Drawing.Size(100, 40)
            };
            this.panAbertura.Controls.Add(lblAbertura);

            Label lblSetor = new Label()
            {
                Text = $"{setor}",
                TextAlign = ContentAlignment.MiddleLeft,
                Location = new System.Drawing.Point(0, yOffset),
                MinimumSize = new System.Drawing.Size(120, 40),
                AutoSize = true,
                Padding = new Padding(10)
            };
            this.panSetor.Controls.Add(lblSetor);

            Label lblMaquina = new Label()
            {
                Text = $"{maquina}",
                TextAlign = ContentAlignment.MiddleLeft,
                Location = new System.Drawing.Point(0, yOffset),
                MinimumSize = new System.Drawing.Size(120, 40),
                AutoSize = true,
                Padding = new Padding(10)
            };
            this.panMaquina.Controls.Add(lblMaquina);

            Label lblDescricao = new Label()
            {
                Text = $"{descricao}",
                TextAlign = ContentAlignment.MiddleLeft,
                Location = new System.Drawing.Point(0, yOffset),
                MinimumSize = new System.Drawing.Size(180, 40),
                AutoSize = true,
                Padding = new Padding(10)
            };
            this.panDescricao.Controls.Add(lblDescricao);

            Label lblStatus = new Label()
            {
                Text = $"{status}",
                TextAlign = ContentAlignment.MiddleCenter,
                Location = new System.Drawing.Point(0, yOffset),
                Size = new System.Drawing.Size(140, 40)
            };
            this.panStatus.Controls.Add(lblStatus);

            if (status == "Não iniciado")
            {
                lblStatus.ForeColor = System.Drawing.Color.Gray;
                Button btnIniciar = new RoundedButton()
                {
                    Text = "Iniciar",
                    Location = new System.Drawing.Point(905, (yOffset +3)),
                    Size = new System.Drawing.Size(90, 36),
                    BackColor = System.Drawing.Color.Gray,
                    ForeColor = System.Drawing.Color.White,
                    FlatStyle = FlatStyle.Flat,
                    Cursor = Cursors.Hand

                };
                btnIniciar.Click += btnIniciar_Click;
                this.panel1.Controls.Add(btnIniciar);
                btnIniciar.Tag = lblStatus;
            }
            else
            {
                lblStatus.ForeColor = System.Drawing.Color.Chocolate;
                Button btnConcluir = new RoundedButton()
                {
                    Text = "Concluir",
                    Location = new System.Drawing.Point(905, (yOffset + 3)),
                    Size = new System.Drawing.Size(90, 36),
                    BackColor = System.Drawing.Color.Chocolate,
                    ForeColor = System.Drawing.Color.White,
                    FlatStyle = FlatStyle.Flat,
                    Cursor = Cursors.Hand
                };
                btnConcluir.Click += btnConcluir_Click;
                this.panel1.Controls.Add(btnConcluir);
                btnConcluir.Tag = lblStatus;
            }

            return (yOffset += 40); 
        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            Button btnAtual = sender as Button;
            btnAtual.BackColor = System.Drawing.Color.Chocolate;
            btnAtual.Text = "Concluir";

            Label lblStatus = btnAtual.Tag as Label;
            lblStatus.Text = "Em andamento";
            lblStatus.ForeColor = System.Drawing.Color.Chocolate;

            btnAtual.Click += btnConcluir_Click;
        }
        
        private void btnConcluir_Click(object sender, EventArgs e)
        {
            Button btnAtual = sender as Button;
            btnAtual.BackColor = System.Drawing.Color.DarkGreen;
            btnAtual.Text = "Cancelar";

            Label lblStatus = btnAtual.Tag as Label;
            lblStatus.Text = "Concluído";
            lblStatus.ForeColor = System.Drawing.Color.DarkGreen;

            btnAtual.Click += btnCancelar_Click;
        }    
        
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Button btnAtual = sender as Button;
            btnAtual.BackColor = System.Drawing.Color.Chocolate;
            btnAtual.Text = "Concluir";

            Label lblStatus = btnAtual.Tag as Label;
            lblStatus.Text = "Em andamento";
            lblStatus.ForeColor = System.Drawing.Color.Chocolate;

            btnAtual.Click += btnConcluir_Click;
        }
        
    }
}

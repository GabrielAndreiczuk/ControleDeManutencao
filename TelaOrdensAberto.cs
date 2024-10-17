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
                    
                    int yOffset = 20;

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
                Location = new System.Drawing.Point(25, yOffset),
                AutoSize = true
            };
            this.panel3.Controls.Add(lblID);

            Label lblSolicitante = new Label()
            {
                Text = $"{solicitante}",
                Location = new System.Drawing.Point(100, yOffset),
                AutoSize = true
            };
            this.panel3.Controls.Add(lblSolicitante);

            Label lblAbertura = new Label()
            {
                Text = $"{abertura}",
                Location = new System.Drawing.Point(225, yOffset),
                AutoSize = true
            };
            this.panel3.Controls.Add(lblAbertura);

            Label lblSetor = new Label()
            {
                Text = $"{setor}",
                Location = new System.Drawing.Point(335, yOffset),
                AutoSize = true
            };
            this.panel3.Controls.Add(lblSetor);

            Label lblMaquina = new Label()
            {
                Text = $"{maquina}",
                Location = new System.Drawing.Point(445, yOffset),
                AutoSize = false,
                Size = new System.Drawing.Size(180, 25)
            };
            this.panel3.Controls.Add(lblMaquina);

            Label lblDescricao = new Label()
            {
                Text = $"{descricao}",
                Location = new System.Drawing.Point(620, yOffset),
                AutoSize = false,
                Size = new System.Drawing.Size(140, 25)
            };
            this.panel3.Controls.Add(lblDescricao);

            Label lblStatus = new Label()
            {
                Text = $"{status}",
                Location = new System.Drawing.Point(775, yOffset),
                AutoSize = true
            };
            this.panel3.Controls.Add(lblStatus);
            label8.Text += lblStatus.AccessibleName;

            if (status == "Não iniciado")
            {
                lblStatus.ForeColor = System.Drawing.Color.Gray;
                Button btnIniciar = new RoundedButton()
                {
                    Text = "Iniciar",
                    Location = new System.Drawing.Point(915, (yOffset - 8)),
                    Size = new System.Drawing.Size(85, 35),
                    BackColor = System.Drawing.Color.Gray,
                    ForeColor = System.Drawing.Color.White,
                    FlatStyle = FlatStyle.Flat,
                    Cursor = Cursors.Hand

                };
                btnIniciar.Click += btnIniciar_Click;
                this.panel3.Controls.Add(btnIniciar);
                btnIniciar.Tag = lblStatus;
            }
            else
            {
                lblStatus.ForeColor = System.Drawing.Color.Chocolate;
                Button btnConcluir = new RoundedButton()
                {
                    Text = "Concluir",
                    Location = new System.Drawing.Point(915, (yOffset - 8)),
                    Size = new System.Drawing.Size(85, 35),
                    BackColor = System.Drawing.Color.Chocolate,
                    ForeColor = System.Drawing.Color.White,
                    FlatStyle = FlatStyle.Flat,
                    Cursor = Cursors.Hand
                };
                btnConcluir.Click += btnConcluir_Click;
                this.panel3.Controls.Add(btnConcluir);
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

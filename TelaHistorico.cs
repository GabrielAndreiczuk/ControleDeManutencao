using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Projeto_TCC
{
    public partial class TelaHistorico : Form
    {
        public TelaHistorico()
        {
            InitializeComponent();
            AdicionarComponentes();
        }

        string id = "", descricao = "", maquina = "", setor = "", duracao = "", tipo = "", custo = "", responsavel = "";

        string connectionString = "Server=localhost;Uid=root;Database=projeto;Port=3306";
        private void AdicionarComponentes()
        {

            List<string> ordens = new List<string>();
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string selectQuery = "SELECT * from view_manutencao";

                    int yOffset = 50;

                    using (MySqlCommand command = new MySqlCommand(selectQuery, connection))
                    {
                        using (MySqlDataReader reader = command.ExecuteReader())
                        {
                            int contColor = 0;
                            while (reader.Read())
                            {
                                id = reader["Ordem"].ToString();
                                descricao = reader["Descrição"].ToString();
                                maquina = reader["Máquina"].ToString();
                                setor = reader["Setor"].ToString();
                                DateTime data = Convert.ToDateTime(reader["Duração"]);
                                duracao = data.ToString("HH:mm");
                                tipo = reader["Tipo"].ToString();
                                custo = reader["Custo"].ToString();
                                responsavel = reader["Responsável"].ToString();

                                Color cor = contColor % 2 == 0 ? Color.Gainsboro : Color.WhiteSmoke;
                                yOffset = AdicionarColunas(yOffset,cor);
                                contColor++;
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private int AdicionarColunas(int yOffset, Color cor)
        {

            Label lblIndice = new Label()
            {
                Text = $"{id}",
                Location = new System.Drawing.Point(0, yOffset),
                Size = new System.Drawing.Size(100, 40),
                
            };
            this.panMenu.Controls.Add(lblIndice);
            
            Label lblID = new Label()
            {
                Text = $"{id}",
                TextAlign = ContentAlignment.MiddleCenter,
                Location = new System.Drawing.Point(0, yOffset),
                Size = new System.Drawing.Size(100, 40),
                BackColor = cor
            };
            this.panID.Controls.Add(lblID);

            Label lblDescricao = new Label()
            {
                Text = $"{descricao}",
                TextAlign = ContentAlignment.MiddleLeft,
                Location = new System.Drawing.Point(0, yOffset),
                MinimumSize = new System.Drawing.Size(180, 40),
                AutoSize = true,
                Padding = new Padding(10),
                BackColor = cor
            };
            this.panDescricao.Controls.Add(lblDescricao);

            Label lblMaquina = new Label()
            {
                Text = $"{maquina}",
                TextAlign = ContentAlignment.MiddleLeft,
                Location = new System.Drawing.Point(0, yOffset),
                MinimumSize = new System.Drawing.Size(120, 40),
                AutoSize = true,
                Padding = new Padding(10),
                BackColor = cor
            };
            this.panMaquina.Controls.Add(lblMaquina);

            Label lblSetor = new Label()
            {
                Text = $"{setor}",
                TextAlign = ContentAlignment.MiddleLeft,
                Location = new System.Drawing.Point(0, yOffset),
                MinimumSize = new System.Drawing.Size(120, 40),
                AutoSize = true,
                Padding = new Padding(10),
                BackColor = cor
            };
            this.panSetor.Controls.Add(lblSetor);

            Label lblDuracao = new Label()
            {
                Text = $"{duracao}",
                TextAlign = ContentAlignment.MiddleLeft,
                Location = new System.Drawing.Point(0, yOffset),
                MinimumSize = new System.Drawing.Size(120, 40),
                AutoSize = true,
                Padding = new Padding(10),
                BackColor = cor
            };
            this.panDuracao.Controls.Add(lblDuracao);

            Label lblTipo = new Label()
            {
                Text = $"{tipo}",
                TextAlign = ContentAlignment.MiddleLeft,
                Location = new System.Drawing.Point(0, yOffset),
                MinimumSize = new System.Drawing.Size(120, 40),
                AutoSize = true,
                Padding = new Padding(10),
                BackColor = cor
            };
            this.panTipo.Controls.Add(lblTipo);

            Label lblCusto = new Label()
            {
                Text = $"R${custo}",
                TextAlign = ContentAlignment.MiddleLeft,
                Location = new System.Drawing.Point(0, yOffset),
                MinimumSize = new System.Drawing.Size(120, 40),
                AutoSize = true,
                Padding = new Padding(10),
                BackColor = cor
            };
            this.panCusto.Controls.Add(lblCusto);

            Label lblResponsavel = new Label()
            {
                Text = $"{responsavel}",
                TextAlign = ContentAlignment.MiddleLeft,
                Location = new System.Drawing.Point(0, yOffset),
                MinimumSize = new System.Drawing.Size(120, 40),
                AutoSize = true,
                Padding = new Padding(10),
                BackColor = cor
            };
            this.panResponsavel.Controls.Add(lblResponsavel);

            /*
            Label lblAbertura = new Label()
            {
                Text = $"{abertura}",
                TextAlign = ContentAlignment.MiddleCenter,
                Location = new System.Drawing.Point(0, yOffset),
                Size = new System.Drawing.Size(100, 40)
            };
            this.panAbertura.Controls.Add(lblAbertura);

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

            Label lblStatus = new Label()
            {
                Text = $"{status}",
                TextAlign = ContentAlignment.MiddleCenter,
                Location = new System.Drawing.Point(0, yOffset),
                Size = new System.Drawing.Size(140, 40),
                TabIndex = int.Parse(lblID.Text)
            };
            index++;
            this.panStatus.Controls.Add(lblStatus);

            if (status == "Não iniciado")
            {
                lblStatus.ForeColor = System.Drawing.Color.Gray;
                Button btnIniciar = new RoundedButton()
                {
                    Text = "Iniciar",
                    Location = new System.Drawing.Point(5, (yOffset + 3)),
                    Size = new System.Drawing.Size(90, 36),
                    BackColor = System.Drawing.Color.Gray,
                    ForeColor = System.Drawing.Color.White,
                    FlatStyle = FlatStyle.Flat,
                    Cursor = Cursors.Hand

                };

                btnIniciar.Click += btnIniciar_Click;
                this.panBotoes.Controls.Add(btnIniciar);
                btnIniciar.Tag = lblStatus;
            }
            else
            {
                lblStatus.ForeColor = System.Drawing.Color.Chocolate;
                Button btnConcluir = new RoundedButton()
                {
                    Text = "Concluir",
                    Location = new System.Drawing.Point(5, (yOffset + 3)),
                    Size = new System.Drawing.Size(90, 36),
                    BackColor = System.Drawing.Color.Chocolate,
                    ForeColor = System.Drawing.Color.White,
                    FlatStyle = FlatStyle.Flat,
                    Cursor = Cursors.Hand
                };

                btnConcluir.Click += btnConcluir_Click;
                this.panBotoes.Controls.Add(btnConcluir);
                btnConcluir.Tag = lblStatus;
            }*/

            return (yOffset += 40);
        }
    }
}

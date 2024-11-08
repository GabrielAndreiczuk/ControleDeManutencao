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
        int index = 0;
        string connectionString = "Server=localhost;Uid=root;Database=projeto;Port=3306";
        private void AdicionarComponentes()
        {
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
                            int contColor = 0;
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

                                Color cor = contColor % 2 == 0 ? Color.FromArgb(38, 79, 120) : Color.FromArgb(0, 36, 72);

                                if (status != "Concluído")
                                {
                                    yOffset = AdicionarColunas(yOffset,cor);
                                    contColor++;
                                }
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
        
        private int AdicionarColunas(int yOffset, Color cor)
        {
            Label lblIndice = new Label()
            {
                Text = $"{id}",
                Location = new System.Drawing.Point(0, yOffset),                
                Size = new System.Drawing.Size(100,40),
                ForeColor = Color.White
            };
            this.panMenu.Controls.Add(lblIndice);

            Label lblID = new Label()
            {
                Text = $"{id}",
                TextAlign = ContentAlignment.MiddleCenter,
                Location = new System.Drawing.Point(0, yOffset),
                Size = new System.Drawing.Size(100, 40),
                BackColor = cor,
                ForeColor = Color.White
            };
            this.panID.Controls.Add(lblID);


            Label lblAbertura = new Label()
            {
                Text = $"{abertura}",
                TextAlign = ContentAlignment.MiddleCenter,
                Location = new System.Drawing.Point(0, yOffset),
                Size = new System.Drawing.Size(100, 40),
                BackColor = cor,
                ForeColor = Color.White
            };
            this.panAbertura.Controls.Add(lblAbertura);

            Label lblSolicitante = new Label()
            {
                Text = $"{solicitante}",
                TextAlign = ContentAlignment.MiddleLeft,
                Location = new System.Drawing.Point(0, yOffset),
                Size = new System.Drawing.Size(130, 40),
                AutoSize = false,
                Padding = new Padding(10),
                BackColor = cor,
                ForeColor = Color.White
            };
            lblSolicitante.Text = AjustarTextoComReticencias(lblSolicitante, solicitante, 75);
            this.panSolicitante.Controls.Add(lblSolicitante); 

            Label lblSetor = new Label()
            {
                TextAlign = ContentAlignment.MiddleLeft,
                Location = new System.Drawing.Point(0, yOffset),
                Size = new System.Drawing.Size(135, 40),
                AutoSize = false,
                Padding = new Padding(10),
                BackColor = cor,
                ForeColor = Color.White
            };
            lblSetor.Text = AjustarTextoComReticencias(lblSetor, setor,80);
            this.panSetor.Controls.Add(lblSetor);

            Label lblMaquina = new Label()
            {
                TextAlign = ContentAlignment.MiddleLeft,
                Location = new System.Drawing.Point(0, yOffset),
                Size = new System.Drawing.Size(135, 40),
                AutoSize = false,
                Padding = new Padding(10),
                BackColor = cor,
                ForeColor = Color.White
            };
            lblMaquina.Text = AjustarTextoComReticencias(lblMaquina, maquina, 80);
            this.panMaquina.Controls.Add(lblMaquina);

            Label lblDescricao = new Label()
            {
                TextAlign = ContentAlignment.MiddleLeft,
                Location = new System.Drawing.Point(0, yOffset),
                MinimumSize = new System.Drawing.Size(180, 40),
                AutoSize = false,
                Padding = new Padding(10),
                BackColor = cor,
                ForeColor = Color.White,          
                Width = this.panDescricao.ClientSize.Width
            };
            lblDescricao.Text = AjustarTextoComReticencias(lblDescricao, descricao, lblDescricao.Width - 20);
            lblDescricao.Tag = descricao;
            //LINKA O REDIMENSIONAMENTO DA TELA COM O TAMANHO DA LABEL DESCRIÇÃO
            this.panDescricao.Resize += (sender, e) => {
                lblDescricao.Width = this.panDescricao.ClientSize.Width;
                string descricaoAtual = lblDescricao.Tag as string;
                lblDescricao.Text = AjustarTextoComReticencias(lblDescricao, descricaoAtual, lblDescricao.Width - 20);
            };
            this.panDescricao.Controls.Add(lblDescricao);

            Label lblStatus = new Label()
            {
                Text = $"{status}",
                TextAlign = ContentAlignment.MiddleCenter,
                Location = new System.Drawing.Point(0, yOffset),
                Size = new System.Drawing.Size(140, 40),
                TabIndex = int.Parse(lblID.Text),
                BackColor = cor,
                ForeColor = Color.White
            };
            index++;
            this.panStatus.Controls.Add(lblStatus);

            if (status == "Não iniciado")
            {
                lblStatus.ForeColor = System.Drawing.Color.White;
                Button btnIniciar = new RoundedButton()
                {
                    Text = "Iniciar",
                    Location = new System.Drawing.Point(5, (yOffset +3)),
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
                lblStatus.ForeColor = System.Drawing.Color.Yellow;
                Button btnConcluir = new RoundedButton()
                {
                    Text = "Concluir",
                    Location = new System.Drawing.Point(5, (yOffset + 3)),
                    Size = new System.Drawing.Size(90, 36),
                    BackColor = System.Drawing.Color.Yellow,
                    ForeColor = System.Drawing.Color.Black,
                    FlatStyle = FlatStyle.Flat,
                    Cursor = Cursors.Hand
                };

                btnConcluir.Click += btnConcluir_Click;
                this.panBotoes.Controls.Add(btnConcluir);
                btnConcluir.Tag = lblStatus;
            }

            return (yOffset += 40); 
        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            Button btnAtual = sender as Button;
            btnAtual.BackColor = System.Drawing.Color.Yellow;
            btnAtual.Text = "Concluir";
            btnAtual.ForeColor = System.Drawing.Color.Black;

            Label lblStatus = btnAtual.Tag as Label;
            lblStatus.Text = "Em andamento";
            lblStatus.ForeColor = System.Drawing.Color.Yellow;
            int ID = lblStatus.TabIndex;

            AtualizarStatus(ID,2);

            btnAtual.Click += btnConcluir_Click;
        }
        
        private void btnConcluir_Click(object sender, EventArgs e)
        {
            Button btnAtual = sender as Button;
            btnAtual.BackColor = System.Drawing.Color.Lime;
            btnAtual.Text = "Cancelar";
            btnAtual.ForeColor = System.Drawing.Color.Black;

            Label lblStatus = btnAtual.Tag as Label;
            lblStatus.Text = "Concluído";
            lblStatus.ForeColor = System.Drawing.Color.Lime;
            int ID = lblStatus.TabIndex;

            AtualizarStatus(ID, 3);
            ConcluirOrdem(ID);

            btnAtual.Click += btnCancelar_Click;
        }    
        
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Button btnAtual = sender as Button;
            btnAtual.BackColor = System.Drawing.Color.Yellow;
            btnAtual.Text = "Concluir";
            btnAtual.ForeColor = System.Drawing.Color.Black;

            Label lblStatus = btnAtual.Tag as Label;
            lblStatus.Text = "Em andamento";
            lblStatus.ForeColor = System.Drawing.Color.Yellow;
            int ID = lblStatus.TabIndex;

            AtualizarStatus(ID, 2);

            btnAtual.Click += btnConcluir_Click;
        }

        private void AtualizarStatus(int id, int status)
        {
            
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    string uptadeQuery = "update abertura_ordem set Status = @Status where ID_Abertura = @ID";

                    using (MySqlCommand command = new MySqlCommand(uptadeQuery, connection))
                    {
                        command.Parameters.AddWithValue("ID", id);
                        command.Parameters.AddWithValue("Status", status);

                        command.ExecuteNonQuery();
                    }
                }
                catch(Exception ex) 
                {
                    
                }
            }
        }

        private void ConcluirOrdem(int id)
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    int Maquina=0, Setor=0;
                    DateTime dataInicial = new DateTime(2023, 1, 1);

                    string selectQuery = "select ID_Maquina,ID_Setor,Data_Abertura from abertura_ordem where ID_Abertura = @ID";

                    using (MySqlCommand cmd = new MySqlCommand(selectQuery, connection))
                    {
                        cmd.Parameters.AddWithValue("@ID", id);
                        
                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                Maquina = int.Parse(reader["ID_Maquina"].ToString());
                                Setor = int.Parse(reader["ID_Setor"].ToString());
                                dataInicial = Convert.ToDateTime(reader["Data_Abertura"]);
                            }
                        }
                    }

                    DateTime dataAtual = DateTime.Now;

                    TimeSpan diferenca = dataAtual.Subtract(dataInicial);


                    //ADICIONAR PESSOA RESPONSAVEL
                    string insertQuery = "insert into manutencao (ID_Ordem,ID_Maquina,ID_Setor,Tempo,Tipo,Responsavel) values (@ID,@Maquina,@Setor,@Tempo,1,@Responsavel)";

                    using (MySqlCommand command = new MySqlCommand(insertQuery, connection))
                    {
                        command.Parameters.AddWithValue("@ID", id);
                        command.Parameters.AddWithValue("@Maquina", Maquina);
                        command.Parameters.AddWithValue("@Setor", Setor);
                        command.Parameters.AddWithValue("@Tempo", diferenca);
                        command.Parameters.AddWithValue("@Responsavel", UsuarioSessao.UsuarioAtual.ID);
                        
                        command.ExecuteNonQuery();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }    
        }


        //MÉTODO QUE AJUSTA O TEXTO AO TAMANHO DA LABEL
        private string AjustarTextoComReticencias(Label label, string texto, int larguraDisponivel)
        {
            using (Graphics g = label.CreateGraphics())
            {
                //int larguraDisponivel = label.Width - label.Padding.Left - label.Padding.Right;
                SizeF tamanhoTexto = g.MeasureString(texto, label.Font);

                if (tamanhoTexto.Width <= larguraDisponivel)
                {
                    return texto; // Se o texto cabe, retorna o texto completo
                }

                // Ajusta o texto com reticências
                string textoAjustado = texto;
                
                while (tamanhoTexto.Width > larguraDisponivel && textoAjustado.Length > 0)
                {
                    textoAjustado = textoAjustado.Substring(0, textoAjustado.Length - 4);
                    
                    tamanhoTexto = g.MeasureString(textoAjustado + "...", label.Font);
                }
                textoAjustado += "...";
                return textoAjustado;
            }
        }
    }
}

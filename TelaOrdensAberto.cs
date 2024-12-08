using MySqlConnector;
using Mysqlx.Crud;
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
    public partial class TelaOrdensAberto : Form
    {
        public void Alert(string msg, FormAlert.enmType type)
        {
            FormAlert frm = new FormAlert();
            frm.showAlert(msg, type);
        }
        public TelaOrdensAberto()
        {
            InitializeComponent();
            AdicionarComponentes();
        }

        //VARIÁVEIS DE ATRIBUTOS DE ORDENS EM ABERTO
        string id = "", solicitante = "", abertura = "", setor = "", maquina = "", descricao = "", status = "";
        int index = 0;

        //STRING DE CONEXÃO COM O BANCO
        string connectionString = "Server=localhost;Uid=root;Database=projeto;Port=3306";

        private void AdicionarComponentes()
        {
            using(MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string selectQuery = "SELECT * from view_ordens_aberto";
                    
                    int yOffset = 50;

                    using (MySqlCommand command = new MySqlCommand(selectQuery, connection))
                    {
                        using (MySqlDataReader reader = command.ExecuteReader())
                        {
                            int contColor = 0;
                            while (reader.Read())
                            {
                                
                                id = reader["Ordem"].ToString();
                                solicitante = reader["ResponsavelAbertura"].ToString();
                                DateTime dataHora = Convert.ToDateTime(reader["DataAbertura"]);
                                abertura = dataHora.ToString("dd/MM/yyyy");
                                setor = reader["Setor"].ToString();
                                maquina = reader["Maquina"].ToString();
                                descricao = reader["DescricaoAbertura"].ToString();
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
            lblSolicitante.Text = AjustarTexto(lblSolicitante, solicitante, 75);
            this.panSolicitante.Controls.Add(lblSolicitante);
            toolTip1.SetToolTip(lblSolicitante, solicitante);

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
            lblSetor.Text = AjustarTexto(lblSetor, setor,80);
            this.panSetor.Controls.Add(lblSetor);
            toolTip1.SetToolTip(lblSetor, setor);

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
            lblMaquina.Text = AjustarTexto(lblMaquina, maquina, 80);
            this.panMaquina.Controls.Add(lblMaquina);
            toolTip1.SetToolTip(lblMaquina, maquina);

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
            lblDescricao.Text = AjustarTexto(lblDescricao, descricao, lblDescricao.Width - 20);
            lblDescricao.Tag = descricao;

            //LINKA O REDIMENSIONAMENTO DA TELA COM O TAMANHO DA LABEL DESCRIÇÃO
            this.panDescricao.Resize += (sender, e) => {
                lblDescricao.Width = this.panDescricao.ClientSize.Width;
                string descricaoAtual = lblDescricao.Tag as string;
                lblDescricao.Text = AjustarTexto(lblDescricao, descricaoAtual, lblDescricao.Width - 20);
            };
            this.panDescricao.Controls.Add(lblDescricao);
            toolTip1.SetToolTip(lblDescricao, descricao);

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
                lblStatus.ForeColor = System.Drawing.Color.FromArgb(255, 204, 153);
                Button btnIniciar = new RoundedButton()
                {
                    Text = "Iniciar",
                    Location = new System.Drawing.Point(10, (yOffset +2)),
                    Size = new System.Drawing.Size(90, 36),
                    BackColor = System.Drawing.Color.FromArgb(255, 204, 153),
                    ForeColor = System.Drawing.Color.Black,
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
                    Location = new System.Drawing.Point(10, (yOffset + 2)),
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

            Label lblFundo = new Label()
            {
                Location = new System.Drawing.Point(0, yOffset),
                Size = new System.Drawing.Size(110, 40),
                BackColor = cor,
            };
            this.panBotoes.Controls.Add(lblFundo);

            return (yOffset += 40); 
        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            if (UsuarioSessao.Acesso() >= 2)
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
            else
            {
                Alert("Ação não autorizada!", FormAlert.enmType.Error);
            }            
        }
        
        private void btnConcluir_Click(object sender, EventArgs e)
        {
            if (UsuarioSessao.Acesso() >= 2)
            {
                Button btnAtual = sender as Button;

                Label lblStatus = btnAtual.Tag as Label;

                int ID = lblStatus.TabIndex;

                TelaMenu tela = new TelaMenu();
                tela.IniciarConclusaoOrdem(ID);
            }
            else
            {
                Alert("Ação não autorizada!", FormAlert.enmType.Error);
            }            
        }    

        private void AtualizarStatus(int id, int status)
        {
            
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    string uptadeQuery = "update manutencao set Status = @Status where ID_Manutencao = @ID";

                    using (MySqlCommand command = new MySqlCommand(uptadeQuery, connection))
                    {
                        command.Parameters.AddWithValue("ID", id);
                        command.Parameters.AddWithValue("Status", status);

                        command.ExecuteNonQuery();
                    }
                }
                catch(Exception ex) 
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        //MÉTODO QUE AJUSTA O TEXTO AO TAMANHO DA LABEL
        private string AjustarTexto(Label label, string texto, int larguraDisponivel)
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

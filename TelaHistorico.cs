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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolBar;

namespace Projeto_TCC
{
    public partial class TelaHistorico : Form
    {
        public TelaHistorico()
        {
            InitializeComponent();

            //CHAMADA DO MÉTODO QUE FAZ A CONSULTA DE DADOS -> INSERÇÃO DE COMPONENTES
            ConsultarDados();
        }

        //VARIÁVEIS GLOBAIS
        string id = "", descricao = "", maquina = "", setor = "", duracao = "", tipo = "", custo = "", responsavel = "";
        string connectionString = "Server=localhost;Uid=root;Database=projeto;Port=3306";

        //MÉTODO QUE FAZ A CONSULTA DAS ORDENS CONCLUÍDAS NO BANCO DE DADOS
        private void ConsultarDados()
        {
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

                                Color cor = contColor % 2 == 0 ? Color.FromArgb(38, 79, 120) : Color.FromArgb(0, 36, 72);
                                yOffset = AdicionarComponentes(yOffset,cor);
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

        //MÉTODO QUE INSERE OS COMPONENTES DE FORMA DINÂMICA CONFORME O BANCO DE DADOS
        private int AdicionarComponentes(int yOffset, Color cor)
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
                BackColor = cor,
                ForeColor = Color.White
            };
            this.panID.Controls.Add(lblID);

            Label lblDescricao = new Label()
            {
                Text = $"{descricao}",
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

            Label lblMaquina = new Label()
            {
                Text = $"{maquina}",
                TextAlign = ContentAlignment.MiddleLeft,
                Location = new System.Drawing.Point(0, yOffset),
                AutoSize = false,
                Size = new System.Drawing.Size(130,40),
                Padding = new Padding(10),
                BackColor = cor,
                ForeColor = Color.White
            };
            lblMaquina.Text = AjustarTexto(lblMaquina, maquina, 70);
            this.panMaquina.Controls.Add(lblMaquina);
            toolTip1.SetToolTip(lblMaquina, maquina);

            Label lblSetor = new Label()
            {
                Text = $"{setor}",
                TextAlign = ContentAlignment.MiddleLeft,
                Location = new System.Drawing.Point(0, yOffset),                
                AutoSize = false,
                Size = new System.Drawing.Size(130, 40),
                Padding = new Padding(10),
                BackColor = cor,
                ForeColor = Color.White
            };
            lblSetor.Text = AjustarTexto(lblSetor, setor, 70);
            this.panSetor.Controls.Add(lblSetor);
            toolTip1.SetToolTip(lblSetor, setor);

            Label lblDuracao = new Label()
            {
                Text = $"{duracao}",
                TextAlign = ContentAlignment.MiddleCenter,
                Location = new System.Drawing.Point(0, yOffset),
                MinimumSize = new System.Drawing.Size(120, 40),
                AutoSize = true,
                Padding = new Padding(-10),
                BackColor = cor,
                ForeColor = Color.White
            };
            this.panDuracao.Controls.Add(lblDuracao);

            Label lblTipo = new Label()
            {
                Text = $"{tipo}",
                TextAlign = ContentAlignment.MiddleCenter,
                Location = new System.Drawing.Point(0, yOffset),
                MinimumSize = new System.Drawing.Size(120, 40),
                AutoSize = true,
                Padding = new Padding(0),
                BackColor = cor,
                ForeColor = Color.White
            };
            this.panTipo.Controls.Add(lblTipo);

            Label lblCusto = new Label()
            {
                Text = $"R${custo}",
                TextAlign = ContentAlignment.MiddleCenter,
                Location = new System.Drawing.Point(0, yOffset),
                MinimumSize = new System.Drawing.Size(120, 40),
                AutoSize = true,
                Padding = new Padding(0),
                BackColor = cor,
                ForeColor = Color.White
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
                BackColor = cor,
                ForeColor = Color.White
            };
            lblResponsavel.Text = AjustarTexto(lblResponsavel, responsavel, 65);
            this.panResponsavel.Controls.Add(lblResponsavel);
            toolTip1.SetToolTip(lblResponsavel, responsavel);

            return (yOffset += 40);
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

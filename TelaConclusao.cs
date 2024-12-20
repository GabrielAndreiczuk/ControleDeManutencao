﻿using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using Button = System.Windows.Forms.Button;

namespace Projeto_TCC
{
    public partial class TelaConclusao : Form
    {
        //MÉTODO CONSTRUTOR
        public TelaConclusao(int ID)
        {
            InitializeComponent();
            id = ID;
        }

        //LISTA DE VARIÁVEIS GLOBAIS
        private List<(int, string, int)> dadosPecas = new List<(int, string, int)>();
        private List<(int, string, int)> _dadosPecas = new List<(int, string, int)>();
        private int id, yOffset = 5, index = 0;
        string connectionString = "Server=localhost;Uid=root;Database=projeto;Port=3306";

        //MÉTODO ALERTA DE NOTIFICAÇÃO
        public void Alert(string msg, FormAlert.enmType type)
        {
            FormAlert frm = new FormAlert();
            frm.showAlert(msg, type);
        }

        //MÉTODO PARA CONTAGEM DE CARACTERES
        int valorDescricao = 0;
        private void txtDescricao_TextChanged(object sender, EventArgs e)
        {
            valorDescricao = txtDescricao.Text.Length;
            lblCaracteres.Text = $"{valorDescricao}/100";
        }

        //MÉTODO QUE LIMITA A INSERÇÃO DE CARACTERES
        private void txtDescricao_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (valorDescricao >= 100 && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }


        //--- MÉTODOS QUE REGISTRAM AS PEÇAS ---

        //MÉTODO PARA INCLUSÃO DE PEÇAS
        private void btnIncluirPecas_Click(object sender, EventArgs e)
        {
            int quantidade = 0;
            int idPecas = 0;
            string nomePecas = "";

            TelaInclusaoPecas pecas = new TelaInclusaoPecas();

            pecas.Closed += (s, args) => quantidade = pecas.Quantidade;
            pecas.Closed += (s, args) => nomePecas = pecas.Nome;
            pecas.Closed += (s, args) => idPecas = pecas.idPecas;

            pecas.Closed += (s, args) => AdicionarComponentes(idPecas, nomePecas, quantidade);
            pecas.Closed += (s, args) => dadosPecas.Add((idPecas, nomePecas, quantidade));
            pecas.Show();
        }

        //MÉTODO QUE ADICIONA PEÇAS SELECIONADAS
        private void AdicionarComponentes(int id ,string nome, int qtd)
        {
            if (nome == "Lista de peças!" || id == 0)
            {
                return;
            }

            lblPecas.Text = $"    ID                        Peças                      Quantidade";

            Label lblId = new Label()
            {
                Text = $"{id}",
                Location = new System.Drawing.Point(0, yOffset),
                Size = new System.Drawing.Size(50, 25),
            };
            this.panInfoPecas.Controls.Add(lblId);

            Label lblID = new Label()
            {
                Text = $"{id}",
                TextAlign = ContentAlignment.MiddleCenter,
                Location = new System.Drawing.Point(0, yOffset),
                Size = new System.Drawing.Size(50, 25),
                ForeColor = Color.FromArgb(0,51,102)
            };            
            this.panID.Controls.Add(lblID);

            Label lblNome = new Label()
            {
                Text = $"{nome}",
                TextAlign = ContentAlignment.MiddleCenter,
                Location = new System.Drawing.Point(0, yOffset),
                Size = new System.Drawing.Size(251, 25),
                ForeColor = Color.FromArgb(0, 51, 102)
            };
            this.panNome.Controls.Add(lblNome);

            Label lblQtd = new Label()
            {
                Text = $"{qtd}",
                TextAlign = ContentAlignment.MiddleCenter,
                Location = new System.Drawing.Point(0, yOffset),
                Size = new System.Drawing.Size(100, 25),
                ForeColor = Color.FromArgb(0, 51, 102)
            };
            this.panQtd.Controls.Add(lblQtd);

            Button btnDelete = new Button()
            {
                //BackgroundImage = Properties.Resources.icon_fechar_item,
                //BackgroundImage = Properties.Resources.iconeExcluirPeca,
                //BackgroundImage = Properties.Resources.iconeExcluir,
                BackgroundImage = Properties.Resources.fecharPecas_icone,
                ImageAlign = ContentAlignment.MiddleCenter,
                Location = new System.Drawing.Point(9, yOffset),
                Size = new System.Drawing.Size(22, 22),
                Cursor = Cursors.Hand,
                ForeColor = System.Drawing.Color.White,
                FlatStyle = FlatStyle.Flat
            };
            this.panDelete.Controls.Add(btnDelete);
            btnDelete.Tag = index;
            btnDelete.Click += btnExcluirPeca_Click;  

            index++;        //INCREMENTA INDEX REFERENTE À POSIÇÃO NA TABELA E NA LISTA
            yOffset += 25;  //INCREMENTA INDEX POSIÇÃO DAS LABELS
        }


        //--- MÉTODOS PARA REMOÇÃO DE PEÇAS ---

        //EVENTO DE CLIQUE DO BOTÃO DE EXCLUIR PEÇAS
        private void btnExcluirPeca_Click(object sender, EventArgs e)
        {
            Button btnAtual = sender as Button;

            int ItemLista = (int) btnAtual.Tag;

            dadosPecas.RemoveAt(ItemLista);
            ResetPecas();

            foreach (var item in dadosPecas.ToList())
            {
                AdicionarComponentes(item.Item1, item.Item2, item.Item3);
            }
        }

        //MÉTODO QUE RESETA PEÇAS SELECIONADAS
        private void ResetPecas()
        {
            lblPecas.Text = "Nenhuma peça foi inclusa...";
            yOffset = 5;
            index = 0;

            panID.Controls.Clear();
            panNome.Controls.Clear();
            panQtd.Controls.Clear();
            panDelete.Controls.Clear();

            foreach (Control control in this.panInfoPecas.Controls)
            {
                if (control is Label)
                {
                    this.panInfoPecas.Controls.Remove(control);
                }
            }
        }

        //--- MÉTODOS DE FINZALIZAÇÃO ---

        //EVENTO CLIQUE DO BOTÃO, ARMAZENA AS VARIÁVEIS
        private void btnConcluir_Click(object sender, EventArgs e)
        {
            int tipo = 0;
            string descricao = txtDescricao.Text;

            //VERIFICA QUAL O TIPO DE MANUTENÇÃO
            if (btnCorretiva.Checked)
            {
                tipo = 1;
            }
            if (btnPreventiva.Checked)
            {
                tipo = 2;
            }
            if (btnPreditiva.Checked)
            {
                tipo = 3;
            }

            //VERIFICA SE A DESCRIÇÃO FOI PREENCHIDA
            if (string.IsNullOrEmpty(txtDescricao.Text))
            {
                Alert("Informe a descrição!", FormAlert.enmType.Info);
                return;
            }

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    int Maquina = 0, Setor = 0;
                    DateTime dataInicial = new DateTime(2023, 1, 1);

                    string selectQuery = "select ID_Maquina,ID_Setor,Data_Abertura from manutencao where ID_Manutencao = @ID";

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
                    string dataConclusao = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");

                    TimeSpan diferenca = dataAtual.Subtract(dataInicial);

                    string duracaoFormatada = string.Format("{0:D2}:{1:D2}:{2:D2}",
                                                                diferenca.Hours,
                                                                diferenca.Minutes,
                                                                diferenca.Seconds);

                    //string updateQuery = "UPDATE manutencao SET Descricao_Conclusao = @Descricao, ID_Maquina = @Maquina, ID_Setor = @Setor, Data_Conclusao = @Data_Conclusao," +
                    //                     "Duracao = @Duracao,Tipo = @Tipo,ID_Funcionario_Conclusao = @Responsavel, Status = 3 WHERE ID_Manutencao = @ID";
                    string updateQuery = "UPDATE manutencao SET Descricao_Conclusao = @Descricao, Data_Conclusao = now()," +
                                         "Duracao = TIMEDIFF(now(), @Data_Inicial),Tipo = @Tipo,ID_Funcionario_Conclusao = @Responsavel, Status = 3 WHERE ID_Manutencao = @ID";


                    using (MySqlCommand command = new MySqlCommand(updateQuery, connection))
                    {
                        command.Parameters.AddWithValue("@ID", id);
                        command.Parameters.AddWithValue("@Descricao", descricao);
                        //command.Parameters.AddWithValue("@Maquina", Maquina);
                        //command.Parameters.AddWithValue("@Setor", Setor);
                        //command.Parameters.AddWithValue("@Data_Conclusao", dataConclusao);
                        command.Parameters.AddWithValue("@Data_Inicial", dataInicial);
                        command.Parameters.AddWithValue("@Duracao", duracaoFormatada);
                        command.Parameters.AddWithValue("@Tipo", tipo);
                        command.Parameters.AddWithValue("@Responsavel", UsuarioSessao.UsuarioAtual.ID);

                        command.ExecuteNonQuery();
                    }

                    updateQuery = "update manutencao set Custo = (hour(Duracao) * (select Valor_Hora from maquina where ID_Maquina = @Maquina)) where ID_Manutencao = @ID";

                    using (MySqlCommand command = new MySqlCommand(updateQuery, connection))
                    {
                        command.Parameters.AddWithValue("@ID", id);
                        command.Parameters.AddWithValue("@Maquina", Maquina);

                        command.ExecuteNonQuery();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    RegistrarPecas();   //RESGISTRA NO BANCO DE DADOS AS PEÇAS SELECIONADAS             

                    TelaMenu menu = new TelaMenu();
                    menu.btnOrdensAberto_Click(sender, EventArgs.Empty);
                    Alert("A ordem foi concluída com sucesso!", FormAlert.enmType.Success);
                }
            }
        }

        //MÉTODO QUE RESGISTRA NO BANCO DE DADOS AS PEÇAS SELECIONADAS
        private void RegistrarPecas()
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    string insertQuery = "insert into pecas_manutencao (ID_Pecas,ID_Manutencao,Quantidade) values (@ID_Pecas,@ID_Manutencao,@Quantidade)";

                    using (MySqlCommand command = new MySqlCommand(insertQuery, connection))
                    {
                        command.Parameters.AddWithValue("@ID_Manutencao", id);
                        command.Parameters.Add("@ID_Pecas", MySqlDbType.Int32);  // Define o tipo de dado explicitamente
                        command.Parameters.Add("@Quantidade", MySqlDbType.Int32);

                        foreach (var item in dadosPecas)
                        {

                            command.Parameters["@ID_Pecas"].Value = item.Item1;
                            command.Parameters["@Quantidade"].Value = item.Item3;

                            command.ExecuteNonQuery();
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
    }
}

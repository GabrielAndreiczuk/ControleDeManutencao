using MySql.Data.MySqlClient;
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
        public TelaConclusao(int ID)
        {
            InitializeComponent();
            id = ID;
        }
        private int id;
        string connectionString = "Server=localhost;Uid=root;Database=projeto;Port=3306";
        int yOffset = 5;
        int index = 1;

        public void Alert(string msg, FormAlert.enmType type)
        {
            FormAlert frm = new FormAlert();
            frm.showAlert(msg, type);
        }

        private void btnConcluir_Click(object sender, EventArgs e)
        {
            int tipo = 0;
            if(btnCorretiva.Checked)
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
            string descricao = txtDescricao.Text;

            ConcluirOrdem(id, tipo, descricao);
        }

        private void ConcluirOrdem(int id, int tipo, string descricao)
        {
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
                    DateTime novaData = dataInicial.Add(diferenca);

                    //ADICIONAR PESSOA RESPONSAVEL
                    string insertQuery = "insert into manutencao (ID_Ordem,Descricao,ID_Maquina,ID_Setor,Tempo,Tipo,Responsavel) values (@ID,@Descricao,@Maquina,@Setor,@Tempo,@Tipo,@Responsavel)";

                    using (MySqlCommand command = new MySqlCommand(insertQuery, connection))
                    {
                        command.Parameters.AddWithValue("@ID", id);
                        command.Parameters.AddWithValue("@Descricao", descricao);
                        command.Parameters.AddWithValue("@Maquina", Maquina);
                        command.Parameters.AddWithValue("@Setor", Setor);
                        command.Parameters.AddWithValue("@Tempo", novaData);
                        command.Parameters.AddWithValue("@Tipo", tipo);
                        command.Parameters.AddWithValue("@Responsavel", UsuarioSessao.UsuarioAtual.ID);

                        command.ExecuteNonQuery();
                    }

                    AtualizarStatus(id, 3);
                    AtribuirPecas();
                    Alert("A ordem foi concluída com sucesso!", FormAlert.enmType.Success);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                btnCorretiva.Checked = true;
                txtDescricao.Text = "";
            }          
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
                catch (Exception ex)
                {

                }
            }
        }

        int valorDescricao = 0;
        private void txtDescricao_TextChanged(object sender, EventArgs e)
        {
            valorDescricao = txtDescricao.Text.Length;
            lblCaracteres.Text = $"{valorDescricao}/100";
        }

        private void txtDescricao_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (valorDescricao >= 100 && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btnIncluirPecas_Click(object sender, EventArgs e)
        {
            int quantidade = 0;
            int idPecas = 0;
            string nomePecas = "";
            TelaInclusaoPecas pecas = new TelaInclusaoPecas();
            pecas.Closed += (s, args) => quantidade = pecas.Quantidade;
            pecas.Closed += (s, args) => nomePecas = pecas.Nome;
            pecas.Closed += (s, args) => idPecas = pecas.idPecas;
            pecas.Closed += (s, args) => AtribuirValor(idPecas,nomePecas, quantidade);
            pecas.Show();
        }

        private List<(int, string, int)> dadosPecas = new List<(int,string, int)>();

        private void AtribuirValor(int id ,string nome, int qtd)
        {
            if (nome == "Lista de peças!" || id == 0)
            {
                return;
            }

            lblPecas.Text = $"    ID                        Peças                      Quantidade";

            Label lblId = new Label()
            {
                Text = $"{id}",
                TextAlign = ContentAlignment.MiddleCenter,
                Location = new System.Drawing.Point(0, yOffset),
                Size = new System.Drawing.Size(50, 25),
                ForeColor = Color.FromArgb(0, 51, 102)
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

            System.Windows.Forms.Button btnDelete = new System.Windows.Forms.Button()
            {
                BackgroundImage = Properties.Resources.icon_fechar_item,
                ImageAlign = ContentAlignment.MiddleCenter,
                Location = new System.Drawing.Point(0, yOffset),
                Size = new System.Drawing.Size(20, 20),
                Cursor = Cursors.Hand
            };
            this.panDelete.Controls.Add(btnDelete);
            btnDelete.Tag = index;
            btnDelete.Click += btnDelete_Click;
            dadosPecas.Add((id,nome,qtd));

            yOffset += 25;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            Button btnAtual = sender as Button;
            int ItemLista = (int) btnAtual.Tag;
            dadosPecas.RemoveAt(ItemLista);
            ResetPecas();
            foreach (var item in dadosPecas)
            {
                AtribuirValor(item.Item1, item.Item2, item.Item3);
            }

        }

        private void AtribuirPecas()
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
                finally
                {
                    ResetPecas();
                }
            }
        }
        private void ResetPecas()
        {
            lblPecas.Text = "Nenhuma peça foi inclusa...";
            yOffset = 5;

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
    }
}

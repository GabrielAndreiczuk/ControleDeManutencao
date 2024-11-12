using MySql.Data.MySqlClient;
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
    public partial class TelaConclusao : Form
    {
        public TelaConclusao(int ID)
        {
            InitializeComponent();
            id = ID;
        }
        private int id;
        string connectionString = "Server=localhost;Uid=root;Database=projeto;Port=3306";

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
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    string selectQuery = "select * from pecas";
                    using (MySqlCommand command = new MySqlCommand(selectQuery, connection))
                    {
                        using (MySqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                lblPecas.Text += $"\n- {reader["Nome"].ToString()}";
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"ERRO: {ex}");
                }
            }
        }
    }
}

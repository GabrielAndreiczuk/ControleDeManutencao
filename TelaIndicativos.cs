using LiveCharts;
using LiveCharts.Wpf;
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
using System.Windows.Forms.DataVisualization.Charting;
using System.Windows.Media;
using Axis = LiveCharts.Wpf.Axis;

namespace Projeto_TCC
{
    public partial class TelaIndicativos : Form
    {
        //MÉTODO QUE CHAMA UMA NOTIFICAÇÃO DE ALERTA
        public void Alert(string msg, FormAlert.enmType type)
        {
            FormAlert frm = new FormAlert();
            frm.showAlert(msg, type);
        }

        private string connectionString = "Server=localhost;Uid=root;Database=projeto;Port=3306;";
        private List<double> custos_mensais = new List<double>();
        private List<double> tempo_medio = new List<double>();

        public TelaIndicativos()
        {
            InitializeComponent();

            PreencherSetor();

            CarregarDados();
        }

        //MÉTODO EXECUTADO NO CARREGAMENTO DA TELA
        private void TelaIndicativos_Load(object sender, EventArgs e)
        {
            Filtrar_Click(sender, EventArgs.Empty);
            toolTip1.SetToolTip(pibMTBF,
            "MTBF é o tempo médio entre falhas de um equipamento ou sistema durante sua operação.\n" +
            "Ele avalia a confiabilidade do ativo, indicando quanto tempo, em média, ele opera sem\n" +
            "interrupções.");
            toolTip1.SetToolTip(pibMTTR,
            "MTTR é o tempo médio necessário para reparar um equipamento ou sistema após uma falha.\n" +
            "Ele mede a eficiência das equipes de manutenção em restaurar a funcionalidade normal,\n" +
            "sendo um indicador chave na gestão de tempo de inatividade.");
        }

        //MÉTODO QUE CARREGA DADOS PARA AS LISTAS        
        private void CarregarDados()
        {
            custos_mensais.Clear();
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    //CARREGAMENTO DE DADOS GRÁFICO CUSTOS
                    string query = "select * from custos_mensais order by Mes";
                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        using (MySqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                custos_mensais.Add(double.Parse(reader["Custo_Total"].ToString()));
                            }
                        }
                    }

                    //CARREGAMENTO DE DADOS GRÁFICO TEMPO MÉDIO
                    query = "select * from tempo_medio order by Mes";
                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        using (MySqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                TimeSpan tempo = (TimeSpan)reader["Tempo"];
                                double hrs = tempo.Hours + (tempo.Days * 24);
                                double min = tempo.Minutes;
                                hrs += min;
                                tempo_medio.Add(hrs);
                            }
                        }
                    }
                    GerarGraficos();
                }
                catch (Exception ex)
                {
                    Alert("Erro de conexão com o banco de dados!", FormAlert.enmType.Error);
                    MessageBox.Show(ex.Message);
                }
            }
        }
        //MÉTODO QUE FAZ A CRIAÇÃO DOS GRÁFICOS
        private void GerarGraficos()
        {

            cartesianChart1.Series = new LiveCharts.SeriesCollection()
            {
                new LineSeries
                {
                    Title = "Custo",
                    Values = new ChartValues<double>(custos_mensais),
                }
            };
            cartesianChart1.AxisX.Clear();
            cartesianChart1.AxisX.Add(new Axis
            {
                Labels = new[] {"set.", "out.", "nov.", "dez."},
                LabelsRotation = 135,
                Separator = new Separator { Step = 1, IsEnabled = true, StrokeThickness = 0.3 }

            });
            cartesianChart1.AxisY.Clear();
            cartesianChart1.AxisY.Add(new Axis
            {
                MinValue = 0,
                LabelFormatter = value => value.ToString("C") // Formatação para o eixo Y (exemplo: moeda)
            });

            //GERAÇÃO DO GRÁFICO DE TEMPO MÉDIO DE MANUTENÇÃO
            cartesianChart2.Series = new LiveCharts.SeriesCollection()
            {
                new LineSeries
                {
                    Title = "Média",
                    Values = new ChartValues<double>(tempo_medio)
                }
            };
            cartesianChart2.AxisX.Clear();
            cartesianChart2.AxisX.Add(new Axis
            {
                Labels = new[] { "set.", "out.", "nov.", "dez." },
                LabelsRotation = 135,
                Separator = new Separator { Step = 1, IsEnabled = true, StrokeThickness = 0.3 }

            });
            cartesianChart2.AxisY.Clear();
            cartesianChart2.AxisY.Add(new Axis
            {
                LabelFormatter = value => $"{value} h",
                MinValue = 0,
            });
        }
        //MÉTODO QUE PREENCHE A COMBOBOX DE SETOR
        private void PreencherSetor()
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
                    row["Nome"] = "Escolha um setor!";
                    dataTable.Rows.InsertAt(row, 0);

                    cmbSetor.DataSource = dataTable;
                    cmbSetor.DisplayMember = "Nome";
                    cmbSetor.SelectedIndex = 0;
                }
                catch (Exception ex)
                {
                    Alert("Erro de conexão com o banco de dados!", FormAlert.enmType.Error);
                    //MessageBox.Show("Erro ao preencher a ComboBox: " + ex.Message);
                }
            }
        }
        //MÉTODO QUE VERIFICA O SETOR SELECIONADO
        private void cmbSetor_SelectedIndexChanged(object sender, EventArgs e)
        {
            PreencherMaquina(cmbSetor.SelectedIndex);
        }
        //PREENCHE A COMBOBOX MÁQUINA CONFORME O SETOR ESCOLHIDO
        private void PreencherMaquina(int setor)
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    string query = "SELECT Nome FROM maquina WHERE Setor = @Setor";

                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Setor", setor);

                        MySqlDataAdapter dataAdapter = new MySqlDataAdapter(command);
                        DataTable dataTable = new DataTable();
                        dataAdapter.Fill(dataTable);

                        DataRow row = dataTable.NewRow();
                        row["Nome"] = "Escolha uma máquina!";
                        dataTable.Rows.InsertAt(row, 0);

                        cmbMaquina.DataSource = dataTable;
                        cmbMaquina.DisplayMember = "Nome";
                        cmbMaquina.SelectedIndex = 0;
                    }

                }
                catch (Exception ex)
                {
                    Alert("Erro de conexão com o banco de dados!", FormAlert.enmType.Error);
                    //MessageBox.Show("Erro ao preencher a ComboBox: " + ex.Message);
                }
            }
        }
        //CLIQUE DO BOTÃO DE FILTRO, RECOLHE E EXPANDE MENU DE SELEÇÃO
        private void Filtrar_Click(object sender, EventArgs e)
        {
            if (pnlFiltros.Height == 150)
            {
                foreach (Control control in pnlFiltros.Controls)
                {
                    if (!(control is Panel) && (control != lblLine))
                    {
                        control.Visible = false;
                    }
                }
                pnlFiltros.Height = 52;
            }
            else
            {
                foreach (Control control in pnlFiltros.Controls)
                {
                    control.Visible = true;
                }
                pnlFiltros.Height = 150;
            }
            
        }
        //MÉTOD QUE APLICA FILTRO DE SELEÇÃO AOS CAMPOS DE MTTR E MTBF
        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            string setor = cmbSetor.Text;
            string maquina = cmbMaquina.Text;

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    string query = "Select MTTR from MTTR where Setor = @setor AND Maquina = @maquina";
                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@setor", setor);
                        command.Parameters.AddWithValue("@maquina", maquina);
                        using (MySqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                TimeSpan tempo = (TimeSpan)reader["MTTR"];
                                double hrs = tempo.Hours + (tempo.Days * 24);
                                double min = tempo.Minutes;
                                string mttr = $"{hrs + (min / 60):F1}";
                                lblMTTR.Text = mttr.ToString();
                            }
                            else
                            {
                                Alert("Nenhum dado corresponde aos filtros aplicados!", FormAlert.enmType.Info);
                                return;
                            }
                        }
                    }

                    query = "Select MTBF from MTBF where Setor = @setor AND Maquina = @maquina";
                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@setor", setor);
                        command.Parameters.AddWithValue("@maquina", maquina);
                        using (MySqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                TimeSpan tempo = (TimeSpan)reader["MTBF"];
                                double hrs = tempo.Hours + (tempo.Days * 24);
                                double min = tempo.Minutes;
                                string mtbf = $"{hrs + (min / 60):F1}";
                                lblMTBF.Text = mtbf.ToString();
                            }
                        }
                    }

                    //CONSULTA DE CUSTO E TOTAL DE MANUTENÇÃO POR MÁQUINA
                    query = "select sum(Custo) as Custo,count(*) as Total from view_manutencao where Máquina = @maquina";
                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        double custo = 0;
                        int total = 0;
                        command.Parameters.AddWithValue("@maquina", maquina);
                        using (MySqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                custo = double.Parse(reader["Custo"].ToString());
                                total = int.Parse(reader["Total"].ToString());
                                label1.Text = maquina;
                                label6.Text = $"O equipamento {maquina} teve um total de {total} manutenções com um custo de {custo:C}";
                            }
                        }                       
                    }
                }
                catch (Exception ex)
                {
                    Alert("Erro de conexão com o banco de dados!", FormAlert.enmType.Error);
                    MessageBox.Show(ex.Message);
                }
            }
        }
        //RESETA OS FILTROS SELECIONADOS
        private void LimparFiltros_Click(object sender, EventArgs e)
        {
            lblMTBF.Text = "-";
            lblMTTR.Text = "-";
            cmbSetor.SelectedIndex = 0;
            cmbMaquina.SelectedIndex = 0;
            label1.Text = "...";
            label6.Text= "Selecione uma máquina para mais detalhes...";
        }
    }    
}

using LiveCharts;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LiveCharts.Wpf;
using LiveCharts.Defaults;
using LiveChartsCore;
using System.Windows.Media;
using MySql.Data.MySqlClient;

namespace Projeto_TCC
{
    public partial class TelaHome : Form
    {
        string connectionString = "Server=localhost;Uid=root;Database=projeto;Port=3306";
        int corretiva = 0, preditiva = 0, preventiva = 0;
        public TelaHome()
        {
            InitializeComponent();                       
        }

        private void TelaHome_Load(object sender, EventArgs e)
        {
            //CHAMA MÉTODO QUE TRÁS INFORMAÇÕES DO BANCO DE DADOS
            CarregarDados();

            //DEFINE A DATA INICIAL COMO O PRIMEIRO DIA DO MÊS ATUAL
            dateInicial.Value = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);
            dateFinal.MaxDate = DateTime.Now;
            dateFinal.Value = DateTime.Now;            
        }

        //VERIFICA SE A DATA INICIAL SELECIONADA É MAIOR QUE A DATA FINAL
        private void dateInicial_ValueChanged(object sender, EventArgs e)
        {
            if(dateInicial.Value > dateFinal.Value)
            {
                dateFinal.Value = dateInicial.Value;
            }
        }
        //VERIFICA SE A DATA FINAL SELECIONADA É MENOR QUE A DATA INICIAL
        private void dateFinal_ValueChanged(object sender, EventArgs e)
        {
            if (dateInicial.Value > dateFinal.Value)
            {
                dateInicial.Value = dateFinal.Value;
            }
        }

        private void roundedButton1_Click(object sender, EventArgs e)
        {
            //CONFIGURAR CARREGAMENTO CORRETO
            pieChart1.Series.Clear();
            CarregarDados();
        }

        //MÉTODO QUE CARREGA AS INFORMAÇÕES DO BANCO DE DADOS
        private void CarregarDados() 
        { 
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    int aberto = 0, concluido = 0;
                    DateTime dataInicio = dateInicial.Value.Date;
                    DateTime dataFim = dateFinal.Value.Date;

                    string selectQuery = "SELECT COUNT(*) FROM manutencao WHERE DATE (Data_Abertura) between @DataInicio AND @DataFinal and Status = 1 OR Status = 2";

                    using (MySqlCommand command = new MySqlCommand(selectQuery, connection))
                    {
                        command.Parameters.AddWithValue("@DataInicio",dataInicio.ToString("yyyy-MM-dd 00:00:00"));
                        command.Parameters.AddWithValue("@DataFinal",dataFim.ToString("yyyy-MM-dd 23:59:59"));

                        aberto = Convert.ToInt32(command.ExecuteScalar());
                        lblAberto.Text = aberto.ToString();                                                
                    }

                    selectQuery = "SELECT COUNT(*) FROM manutencao WHERE DATE (Data_Conclusao) between @DataInicio AND @DataFinal AND Status = 3";
                    using (MySqlCommand command = new MySqlCommand(selectQuery, connection))
                    {
                        command.Parameters.AddWithValue("@DataInicio", dataInicio.ToString("yyyy-MM-dd 00:00:00"));
                        command.Parameters.AddWithValue("@DataFinal", dataFim.ToString("yyyy-MM-dd 23:59:59"));

                        concluido = Convert.ToInt32(command.ExecuteScalar());
                        lblConcluido.Text = concluido.ToString();
                    }

                    corretiva = 0;
                    preditiva = 0;
                    preventiva = 0;

                    selectQuery = "SELECT (Tipo) FROM manutencao";
                    using (MySqlCommand command = new MySqlCommand(selectQuery, connection))
                    {
                        using (MySqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                int selecao = int.Parse(reader["Tipo"].ToString());
                                switch (selecao)
                                {
                                    case 1:
                                        corretiva++;
                                        break;
                                    case 2:
                                        preventiva++;
                                        break;
                                    case 3:
                                        preditiva++;
                                        break;
                                    default:
                                        break;
                                }
                            }
                        }
                    }                       
                    GerarGraficos();                    
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
        }

        //MÉTODO QUE GERA GRÁFICOS E INFORMAÇÕES NA TELA
        private void GerarGraficos()
        {
            pieChart1.Series = new SeriesCollection
            {
                new PieSeries {
                    Title = "Corretiva",
                    Values = new ChartValues<double> {corretiva},
                    DataLabels = true,
                    Fill = new SolidColorBrush(System.Windows.Media.Color.FromRgb(244, 67, 54))
                },
                new PieSeries {
                    Title = "Preventiva",
                    Values = new ChartValues<double> {preventiva},
                    DataLabels = true,
                    Fill = new SolidColorBrush(System.Windows.Media.Color.FromRgb(76, 175, 80))
                },
                new PieSeries {
                    Title = "Preditiva",
                    Values = new ChartValues < double > { preditiva }, 
                    DataLabels = true,
                    Fill = new SolidColorBrush(System.Windows.Media.Color.FromRgb(54, 124, 221))
                },
            };
            pieChart1.LegendLocation = LegendLocation.Right;
            pieChart1.DefaultLegend.Foreground = System.Windows.Media.Brushes.White;
            pieChart1.DataTooltip.Background = System.Windows.Media.Brushes.White;
            pieChart1.DataTooltip.Foreground = new SolidColorBrush(System.Windows.Media.Color.FromArgb(255, 0, 54, 102));
        }
    }
}

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

namespace Projeto_TCC
{
    public partial class TelaHome : Form
    {
        public TelaHome()
        {
            InitializeComponent();
        }

        private void TelaHome_Load(object sender, EventArgs e)
        {
            GerarGraficos();
        }

        private void GerarGraficos()
        {
            pieChart1.Series = new SeriesCollection
            {
                new PieSeries {
                    Title = "Corretiva",
                    Values = new ChartValues<double> {20},
                    DataLabels = true,
                    Fill = new SolidColorBrush(System.Windows.Media.Color.FromRgb(244, 67, 54))
                },
                new PieSeries {
                    Title = "Preventiva",
                    Values = new ChartValues<double> {35},
                    DataLabels = true,
                    Fill = new SolidColorBrush(System.Windows.Media.Color.FromRgb(76, 175, 80))
                },
                new PieSeries {
                    Title = "Preditiva",
                    Values = new ChartValues < double > { 45 }, 
                    DataLabels = true,
                    Fill = new SolidColorBrush(System.Windows.Media.Color.FromRgb(54, 124, 221))
                },
            };
            pieChart1.LegendLocation = LiveCharts.LegendLocation.Right;          


            chart1.Series.Clear();
            /*
            var series = new System.Windows.Forms.DataVisualization.Charting.Series
            {
                Name = "Exemplo",
                IsVisibleInLegend = true,
                ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie, // ou outro tipo de gráfico
            };

            series.Points.AddXY("Categoria A",50);
            series.Points.AddXY("Categoria B",20);
            series.Points.AddXY("Categoria C",30);


            chart1.Legends[0].Font = new System.Drawing.Font("Arial", 12);
            //chart1.Legends[1].Font = new System.Drawing.Font("Arial", 12);
            //chart1.Legends[2].Font = new System.Drawing.Font("Arial", 12);

            series.Points[0].Color = .Red;
            series.Points[1].Color = Color.Blue;
            series.Points[2].Color = Color.Green;

            chart1.Series.Add(series);

            // Ajustar a aparência do gráfico, se necessário
            chart1.Titles.Add("Exemplo de Gráfico de Pizza");
            */
        }
    }
}

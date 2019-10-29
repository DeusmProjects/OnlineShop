using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xceed.Document.NET;
using Xceed.Words.NET;

namespace MaxinLib
{
    public partial class WordDiagram : Component
    {
        public WordDiagram()
        {
            InitializeComponent();
        }

        public WordDiagram(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
        }

        public void CreateDiagram()
        {
            string pathDocument = AppDomain.CurrentDomain.BaseDirectory + "diagram.docx";

            // создаём документ
            DocX document = DocX.Create(pathDocument);

            document.InsertChart(CreateBarChart());

            document.Save();
        }

        private static Chart CreateBarChart()
        {
            // создаём столбцовую диаграмму
            BarChart barChart = new BarChart();
            // отображаем легенду сверху диаграммы
            barChart.AddLegend(ChartLegendPosition.Top, false);

            // создаём набор данных и добавляем в диаграмму
            barChart.AddSeries(TestData.GetSeriesFirst());

            return barChart;
        }
    }
}

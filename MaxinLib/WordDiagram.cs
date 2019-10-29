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

            document.InsertChart(CreateLineChart());
            document.InsertChart(CreateBarChart());
            document.InsertChart(CreatePieChart());
            document.InsertChart(Create3DBarChart());

            document.Save();
        }

        private static Chart CreateLineChart()
        {
            // создаём линейную диаграмму
            LineChart lineChart = new LineChart();
            // добавляем легенду вниз диаграммы
            lineChart.AddLegend(ChartLegendPosition.Bottom, false);

            // создаём набор данных и добавляем на диаграмму
            lineChart.AddSeries(TestData.GetSeriesFirst());
            // добавляем ещё один набор
            lineChart.AddSeries(TestData.GetSeriesSecond());

            return lineChart;
        }

        private static Chart CreatePieChart()
        {
            // создаём круговую диаграмму
            PieChart pieChart = new PieChart();
            // добавляем легенду слева от диаграммы
            pieChart.AddLegend(ChartLegendPosition.Left, false);

            // создаём набор данных и добавляем на диаграмму
            pieChart.AddSeries(TestData.GetSeriesFirst());

            return pieChart;
        }

        private static Chart CreateBarChart()
        {
            // создаём столбцовую диаграмму
            BarChart barChart = new BarChart();
            // отображаем легенду сверху диаграммы
            barChart.AddLegend(ChartLegendPosition.Top, false);

            // создаём набор данных и добавляем в диаграмму
            barChart.AddSeries(TestData.GetSeriesFirst());
            // создаём набор данных и добавляем в диаграмму
            barChart.AddSeries(TestData.GetSeriesSecond());

            return barChart;
        }

        private static Chart Create3DBarChart()
        {
            // создаём столбцовую диаграмму
            BarChart barChart = new BarChart();
            // отображаем легенду снизу диаграммы
            barChart.AddLegend(ChartLegendPosition.Bottom, false);
            // добавление 3D эффекта
            barChart.View3D = true;

            // создаём набор данных и добавляем в диаграмму
            barChart.AddSeries(TestData.GetSeriesFirst());
            // создаём набор данных и добавляем в диаграмму
            barChart.AddSeries(TestData.GetSeriesSecond());

            return barChart;
        }
    }
}

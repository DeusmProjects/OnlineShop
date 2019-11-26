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
        public string DiagramName { get; set; }
        public string Name { get; set; }
        public string Value { get; set; }
        public List<object> Data { get; set; }

        public WordDiagram()
        {
            InitializeComponent();
        }

        public WordDiagram(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
        }

        public void CreateDiagram(IEnumerable<object> data, string diagramName, string name, string value, string path)
        {
            Data = data.ToList();
            DiagramName = diagramName;
            Name = name;
            Value = value;

            string pathDocument = path + ".docx";

            // создаём документ
            DocX document = DocX.Create(pathDocument);

            document.InsertChart(CreateBarChart());

            document.Save();
        }

        private Chart CreateBarChart()
        {
            BarChart barChart = new BarChart();

            barChart.AddLegend(ChartLegendPosition.Top, false);

            var series = new Series(DiagramName);

            series.Bind(Data, Name, Value);

            barChart.AddSeries(series);

            return barChart;
        }
    }
}

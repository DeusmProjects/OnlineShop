using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using Excel = Microsoft.Office.Interop.Excel;

namespace MaxinLib
{
    public partial class ExcelReport : Component
    {
        public ExcelReport()
        {
            InitializeComponent();
        }

        public ExcelReport(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
        }

        public string Header { get; set; }

        private void GetHeader(Excel.Worksheet sheet)
        {
            var columns = Header.Split(',');

            for (int i = 0; i < columns.Length; i++)
            {
                sheet.Cells[1, i + 1] = columns[i].Split(' ')[0];
            }
        }

        public void CreateReport(IEnumerable<object> data)
        {
            var excel = new Excel.Application
            {
                Visible = true,

                SheetsInNewWorkbook = 1
            };

            var workbook = excel.Workbooks.Add(Type.Missing);

            excel.DisplayAlerts = false;

            var sheet = (Excel.Worksheet) excel.Worksheets.Item[1];

            sheet.Name = "Отчет";

            GetHeader(sheet);

            for (int i = 0; i < data.ToList().Count; i++)
            {
                var props = Header.Split(',');

                for (int j = 0; j < props.Length; j++)
                {
                    sheet.Cells[i + 2, j + 1] = data.ToList()[i].GetType().GetProperty(props[j].Split(' ')[1]).GetValue(data.ToList()[i]);
                }
            }

            excel.Application.ActiveWorkbook.SaveAs("report.xlsx", Type.Missing,
            Type.Missing, Type.Missing, Type.Missing, Type.Missing, Excel.XlSaveAsAccessMode.xlNoChange,
            Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing);

            //excel.Quit();
        }
    }
}

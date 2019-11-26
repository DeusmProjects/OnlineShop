using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SharafutdinovaLib
{
    public partial class ValueTable : UserControl
    {
        private string[] columns;

        public ValueTable()
        {
            InitializeComponent();
        }

        public void AddData(IEnumerable<object> objects, string columns)
        {
            dataGridView.Rows.Clear();
            dataGridView.Columns.Clear();
            this.columns = columns.Split(',');
            MakeColumns();
            MakeRows(objects);
        }

        private void MakeRows(IEnumerable<object> objects)
        {
            foreach (var o in objects)
            {
                MakeRow(o);
            }
        }

        private void MakeRow(object o)
        {
            var fields = o.GetType().GetProperties();
            var values = new List<object>();
            foreach(var column in columns)
            {
                var field = fields.First(x => x.Name == column);
                values.Add(field.GetValue(o));
            }
            dataGridView.Rows.Add(values.ToArray());
        }

        private void MakeColumns()
        {
            foreach (var column in columns)
            {
                DataGridViewCell dgvc = new DataGridViewTextBoxCell();
                dataGridView.Columns.Add(new DataGridViewColumn { Name = column, Width = 120, CellTemplate=dgvc });
            }
        }
    }
}

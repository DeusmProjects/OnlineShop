using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SharafutdinovaForm
{


    public partial class FormTest2 : Form
    {
        public FormTest2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var list = new List<Test> { new Test { Name = "A", Adress = "a1", Number = 1 }, new Test { Name = "B", Adress = "b1", Number = 2 } };
            wordReport1.Doc(list, "B://3 курс//КОП//test.doc", "Name,Adress,Number");
            MessageBox.Show("Все хорошо!");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var list = new List<Test2> { new Test2 { Date = DateTime.Parse("11.12.2018"), Number = 1 }, new Test2 { Date = DateTime.Parse("13.12.2018"), Number = 5 }, new Test2 { Date = DateTime.Parse("16.12.2018"), Number = 7 } };
            diagramPDF1.Doc(list, "B://3 курс//КОП//test.pdf", "Date", "Number");
            MessageBox.Show("Все хорошо!");

        }
    }

    public class Test2
    {
        public DateTime Date;

        public double Number;
    }
}

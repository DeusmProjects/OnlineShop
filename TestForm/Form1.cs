using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            controlListBoxSelected1.LoadEnumeration(new List<string>{"Москва", "Ульяновск", "Киев"});
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            var city = controlListBoxSelected1.SelectedText;
            var index = controlListBoxSelected1.SelectedIndex;

            if (!city.Equals(""))
            {
                MessageBox.Show(
                    $"Выбран город {city} - {index}");
            }
            else
            {
                MessageBox.Show("Город не выбран");
            }
        }
    }
}

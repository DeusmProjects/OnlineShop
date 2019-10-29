using SharafutdinovaLib;
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
    public class Test
    {
        public string Name;

        public int Number;

        public string Adress;
    }

    public partial class FormTest : Form
    {
        public FormTest()
        {
            InitializeComponent();
            comboBoxSelected.LoadEnumeration(typeof(TestEnum));
            comboBoxSelected.SelectedIndex = (int)TestEnum.Принят;
        }

        private void buttonChange_Click(object sender, EventArgs e)
        {
            comboBoxSelected.SelectedIndex = 0;
        }

        private void controlComboBoxSelected_ComboBoxSelectedElementChange(object sender, EventArgs e)
        {
            MessageBox.Show(comboBoxSelected.SelectedText);
        }

        private void valueTable1_Load(object sender, EventArgs e)
        {
            var list = new List<Test> { new Test { Name = "A", Adress = "a1", Number = 1 }, new Test { Name = "B", Adress = "b1", Number = 2 } };
            valueTable1.AddData(list, "Name,Adress,Number");
        }
    }
}

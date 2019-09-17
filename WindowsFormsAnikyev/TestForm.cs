using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsAnikyev
{
    public partial class TestForm : Form
    {
        public TestForm()
        {
            InitializeComponent();
            controlCheckedListBoxSelected1.LoadList(new List<string> { "Element 1", "Element 2", "Element 3", "Element 4" });
        }

        private void controlCheckedListBoxSelected_CheckedListBoxSelectedElementsChange(object sender, EventArgs e)
        {
            controlCheckedListBoxSelected1.CheckedValue.ForEach( element => MessageBox.Show(element));
        }

        private void buttonChangingChoosed_Click(object sender, EventArgs e)
        {
            controlCheckedListBoxSelected1.CheckedIndeces = new List<int> { 0, 3};
        }
    }
}

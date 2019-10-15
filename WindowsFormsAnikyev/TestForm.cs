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
            controlCheckedListBox1.LoadList(new List<string> { "Element 1", "Element 2", "Element 3", "Element 4" });
            controlTreeView1.AddNode("Тест", "/");
            controlTreeView1.AddNode("Тест", "/");
            controlTreeView1.AddNode("Подтест", "/Тест/");
            controlTreeView1.AddNode("Под Под тест", "/Тест/Подтест/");
        }

        private void controlCheckedListBoxSelected_CheckedListBoxSelectedElementsChange(object sender, EventArgs e)
        {
            controlCheckedListBox1.CheckedValue.ForEach(element => MessageBox.Show(element));
        }

        private void buttonChangingChoosed_Click(object sender, EventArgs e)
        {
            controlCheckedListBox1.CheckedIndeces = new List<int> { 0, 3};
        }

        private void button1_Click(object sender, EventArgs e)
        {
            componentCreateBackup1.OutputPath = "C:\\Users\\aniky\\Desktop\\University\\3 курс\\5 семестр\\Компонентно-ориентированное программирование";
            Test[] tests = new Test[5];
            for (int i = 0; i < tests.Length; i++)
            {
                tests[i] = new Test("name" + i, "descr" + i, 10 + i);
            }
            componentCreateBackup1.Save<Test>(tests, "myfile");
        }
    }
}

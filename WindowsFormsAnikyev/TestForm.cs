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

        private void button2_Click(object sender, EventArgs e)
        {
            componentExportDiagram1.SetCaptions(new List<string> { "Москва", "Ульяновск", "Казань", "Ростов", "Рязань" });
            componentExportDiagram1.SetValues(new List<int> { 5, 10, 6, 1, 4});
            componentExportDiagram1.Export(@"C:\Users\aniky\Desktop\University\3 курс\5 семестр\Компонентно-ориентированное программирование\diagramm.xls");
            Console.WriteLine("Exported");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            componentExportReport1.SetHeaders(new List<string> { "Москва", "Ульяновск", "Казань"});
            componentExportReport1.SetValues(new List<List<string>> {
                new List<string> { "МоскваСтрока1", "УльяновскСтрока1", "КазаньСтрока1"},
                new List<string> { "МоскваСтрока2", "УльяновскСтрока2", "КазаньСтрока2"},
                new List<string> { "МоскваСтрока3", "УльяновскСтрока3", "КазаньСтрока3"},
                new List<string> { "МоскваСтрока4", "УльяновскСтрока4", "КазаньСтрока4" } });
            componentExportReport1.SetStringConcatenation(new List<int[]> {
                new int[] { 0, 2, 2},
                new int[] { 1, 1, 2}});
            componentExportReport1.Export(@"C:\Users\aniky\Desktop\University\3 курс\5 семестр\Компонентно-ориентированное программирование\report.pdf");
            Console.WriteLine("Exported");
        }
    }
}

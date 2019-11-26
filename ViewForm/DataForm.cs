using ImplementDB;
using Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Unity;

namespace ViewForm
{
    public partial class DataForm : Form
    {
        [Dependency] public new IUnityContainer Container { get; set; }

        private readonly IMainService service;
        SaveFileDialog saveFileDialog = new SaveFileDialog();

        public DataForm(IMainService service)
        {
            InitializeComponent();
            this.service = service;

        }
        private void Main_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
            try
            {
                List<Main> list = service.GetList();
                if (list != null)
                {
                    valueTable1.AddData(list, "Id,City,Email");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void buttonCreate_Click(object sender, EventArgs e)
        {
            var form = Container.Resolve<CreateForm>();
            if (form.ShowDialog() == DialogResult.OK)
            {
                LoadData();
            }
        }

        private void загрузкаДанныхToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if(openFileDialog.ShowDialog() == DialogResult.OK)
            {
                var path = openFileDialog.FileName;
                var list = dataLoading1.LoadObject<Main>(path);
                valueTable1.AddData(list, "Id,City,Email");
            }
            
        }

        private void диаграммаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var list = new List<string>();

            foreach (var elem in service.GetList())
            {
                var fields = elem.GetType().GetProperties();
                var field = fields.First(x => x.Name == "City");
                list.Add(field.GetValue(elem).ToString());
            }

            list.Sort();
            var listInt = new List<int>();
            var listName = list.Distinct().ToList();
            
            int k = 0;
            var city = list[0];
            for (int i = 0; i < list.Count(); i++)
            {
                if (city == list[i])
                {
                    k++;
                }
                else
                {
                    listInt.Add(k);
                    k = 1;
                    city = list[i];
                }
            }
            listInt.Add(k);
            componentExportDiagram1.SetCaptions(listName);
            componentExportDiagram1.SetValues(listInt);
            saveFileDialog = new SaveFileDialog();
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                var path = saveFileDialog.FileName;
                componentExportDiagram1.Export(path);
            }
        }

        private void отчетToolStripMenuItem_Click(object sender, EventArgs e)
        {
            excelReport1.Header = "Номер Id,Почта Email";
            excelReport1.CreateReport(service.GetList());
        }

        private void созданиеБэкапаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFileDialog = new SaveFileDialog();
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                var path = saveFileDialog.FileName;
                componentCreateBackup1.OutputPath = path;
                componentCreateBackup1.Save<Main>(service.GetList().ToArray(), saveFileDialog.FileName);
            }
                

        }
    }
}

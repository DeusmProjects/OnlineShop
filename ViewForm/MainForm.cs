using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ImplementationsDB;

namespace ViewForm
{
    public partial class MainForm : Form
    {
        private OrderService service;

        public MainForm()
        {
            service = new OrderService();
            InitializeComponent();

            comboBoxSelected1.LoadEnumeration(typeof(Status));
            LoadTree(service.GetOrders());
        }

        private void LoadTree(List<Order> list)
        {
            foreach (var status in Enum.GetValues(typeof(Status)))
            {
                controlTreeView1.AddNode(status.ToString(), "/");
            } 
            list.ForEach(element =>
            {
                controlTreeView1.AddNode(element.Count != -1 ? element.Count.ToString() : "Нет", $"/{Enum.GetValues(typeof(Status)).GetValue(element.Status)}/");
            });            
        }

        private void ClearTree()
        {
            controlTreeView1.Clear();
            LoadTree(new List<Order>());
        }

        private void buttonCreate_Click(object sender, EventArgs e)
        {
            float count;
            var textCount = controlTextBoxInput1.TextBoxValue;
            if (textCount == null)
            {
                count = -1;
            }
            else
            {
                try
                {
                    count = (float)Convert.ToDouble(textCount);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                    return;
                }
            }
            service.CreateOrder(new Order
            {
                Status = comboBoxSelected1.SelectedIndex,
                Count = count
            });
            controlTreeView1.AddNode(count != -1 ? count.ToString() : "Нет", $"/{Enum.GetValues(typeof(Status)).GetValue(comboBoxSelected1.SelectedIndex)}/");
        }

        private string GetWay(int state)
        {
            switch(state)
            {
                case 0: return "/Created/";
                case 1: return "/Taken/";
                case 2: return "/AwaitDelivery/";
                case 3: return "/Ready/";
                default: return null;
            }
        }

        private void buttonRemove_Click(object sender, EventArgs e)
        {
            service.RemoveAll();
            ClearTree();
            MessageBox.Show("Все элементы успешно удалены");
        }

        private void buttonCreateBackup_Click(object sender, EventArgs e)
        {
            var saveFileDialog = new SaveFileDialog();
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                componentCreateBackup1.OutputPath = saveFileDialog.FileName;
                componentCreateBackup1.Save<Order>(service.GetOrders().ToArray(), "Orders");
                MessageBox.Show("Бекап создан");
            }
        }

        private void buttonWordReport_Click(object sender, EventArgs e)
        {
            var saveFileDialog = new SaveFileDialog();
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                wordReport1.Doc(service.GetOrders().Select(order => new {
                    Status = Enum.GetValues(typeof(Status)).GetValue(order.Status),
                    Count = order.Count != -1 ? order.Count.ToString() : "Нет"
                }), saveFileDialog.FileName, "Status,Count");
                MessageBox.Show("Отчет создан");
            }
        }

        private void buttonWordDiagram_Click(object sender, EventArgs e)
        {
            var saveFileDialog = new SaveFileDialog();
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                wordDiagram1.CreateDiagram(service.GetOrders().Select(order => new
                {
                    Status = Enum.GetValues(typeof(Status)).GetValue(order.Status),
                    Count = order.Count != -1 ? order.Count.ToString() : "Нет"
                }), "Диаграмма заказов", "Status", "Count", saveFileDialog.FileName);
                MessageBox.Show("Диаграмма создана");
            }
        }
    }
}

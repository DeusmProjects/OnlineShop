using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace TestForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            controlListBoxSelected1.LoadEnumeration(new List<string>{"Москва", "Ульяновск", "Киев"});

            controlListBoxView1.Pattern = "Номер - {Number}, Дата - {DateCreate}";

            controlListBoxView1.AddElement(new { Number = 1, DateCreate = DateTime.Now });
            controlListBoxView1.AddElement(new { Number = 2, DateCreate = DateTime.Now });
            controlListBoxView1.AddElement(new { Number = 3, DateCreate = DateTime.Now, Hi = "ddd" });
        }

        private void controlListBoxSelected_ListBoxSelectedElementChange(object sender, EventArgs e)
        {
            var city = controlListBoxSelected1.SelectedText;
            var index = controlListBoxSelected1.SelectedIndex;

            MessageBox.Show($"Выбран город {city} - {index}");
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            controlListBoxSelected1.SelectedIndex = 0;
        }

        private void controlTextBoxInput_CheckBoxChange(object sender, EventArgs e)
        {
            //controlTextBoxInput1.TextBoxValue = null;
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            int? sum = controlTextBoxInput1.TextBoxValue;

            if (controlTextBoxInput1.IsChecked)
            {
                MessageBox.Show("Выбрано значение null");
            }
            else
            {
                if (sum.HasValue)
                {
                    if (sum != -1)
                    {
                        MessageBox.Show("Сумма: " + sum.Value);
                    }
                    else
                    {
                        MessageBox.Show("Некорректное значение");
                    }
                }
                else
                {
                    controlTextBoxInput1.IsChecked = true;
                }
            }
        }

        private void ControlTextBoxInput1_CheckBoxChange(object sender, EventArgs e)
        {
            //var isChecked = controlTextBoxInput1.isChecked;

            //controlTextBoxInput1.isChecked = !isChecked;
        }

        private void ButtonCreateReport_Click(object sender, EventArgs e)
        {
            excelReport.Header = "Имя Name,Почта Mail";

            excelReport.CreateReport(new List<object>
            {
                new { Mail = "first", Name = "vlad" },
                new { Mail = "second", Name = "vika" },
                new { Mail = "third", Name = "danila" },
            });
        }

        private void ButtonCreateDiagram_Click(object sender, EventArgs e)
        {
            //wordDiagram.CreateDiagram();
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;
using TestForm;

namespace MaxinLib
{
    public partial class ControlListBoxView : UserControl
    {
        private int _selectedIndex;

        public string Pattern { get; set; }

        private event EventHandler _listBoxViewElementChange;

        public ControlListBoxView()
        {
            InitializeComponent();
            listBox.SelectedIndexChanged += (sender, e) => {
                _listBoxViewElementChange?.Invoke(sender, e);
            };
        }

        [Category("Спецификация"), Description("Порядковый номер выбранного элемента")]
        public int SelectedIndex
        {
            get => listBox.SelectedIndex;
            set
            {
                if (value > -2 && value < listBox.Items.Count)
                {
                    _selectedIndex = value;
                    listBox.SelectedIndex = _selectedIndex;
                }
            }
        }

        [Category("Спецификация"), Description("Текст выбранной записи")]
        public string SelectedText => listBox.Text;

        [Category("Спецификация"), Description("Событие выбора элемента из списка")]
        public event EventHandler ListBoxViewElementChange
        {
            add => _listBoxViewElementChange += value;
            remove => _listBoxViewElementChange -= value;
        }

        public void AddElement(object element)
        {
            var type = element.GetType();
            var props = type.GetProperties().ToList();

            var names = props.Select(prop => prop.Name);

            string outString = Pattern;

            foreach (var name in names)
            {
                outString = outString.Replace("{" + name + "}", element.GetType().GetProperty(name).GetValue(element).ToString());
            }



            listBox.Items.Add(outString);
        }
    }
}
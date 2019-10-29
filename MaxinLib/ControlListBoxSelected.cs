using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;

namespace MaxinLib
{
    public partial class ControlListBoxSelected : UserControl
    {
        private int _selectedIndex;

        private event EventHandler _listBoxSelectedElementChange;

        public ControlListBoxSelected()
        {
            InitializeComponent();
            listBox.SelectedIndexChanged += (sender, e) => {
                _listBoxSelectedElementChange?.Invoke(sender, e);
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
        public event EventHandler ListBoxSelectedElementChange
        {
            add => _listBoxSelectedElementChange += value;
            remove => _listBoxSelectedElementChange -= value;
        }

        public void LoadEnumeration(List<string> elements)
        {
            elements.ForEach(element => listBox.Items.Add(element));
        }

    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AnikyevLib
{
    public partial class ControlCheckedListBox : UserControl
    {
        /// <summary>
        /// Порядковые номера выбранных элементов
        /// </summary>
        private List<int> _checkedIndeces;

        /// <summary>
        /// Событие выбора элемента из списка
        /// </summary>
        private event EventHandler _checkedListBoxSelectedElementChoose;

        /// <summary>
        /// Порядковые номера отмеченных элементов
        /// </summary>
        [Category("Спецификация"), Description("Порядковые номера отмеченных элементов")]
        public List<int> CheckedIndeces
        {
            get { return _checkedIndeces; }
            set
            {
                checkedListBox.ClearSelected();
                if (value == null) return;
                for (int i = 0; i < value.Count; i++)
                {
                    if (value[i] > -1 && value[i] <= checkedListBox.Items.Count)
                    {
                        checkedListBox.SetItemChecked(value[i], true);
                    }
                }
                _checkedIndeces = value;
            }
        }

        /// <summary>
        /// Текст отмеченных записей
        /// </summary>
        [Category("Спецификация"), Description("Текст выбранной записи")]
        public List<string> CheckedValue
        {
            get {
                List<string> list = new List<string>();
                for (int i = 0; i < checkedListBox.CheckedItems.Count; i++)
                {
                    list.Add(checkedListBox.CheckedItems[i].ToString());
                }
                return list;
            }
        }

        /// <summary>
        /// Событие отметки элемента из списка
        /// </summary>
        [Category("Спецификация"), Description("Событие отметки элемента из списка")]
        public event EventHandler CheckedListBoxSelectedElementChoose
        {
            add { _checkedListBoxSelectedElementChoose += value; }
            remove { _checkedListBoxSelectedElementChoose -= value; }
        }

        /// <summary>
        /// Конструктор
        /// </summary>
        public ControlCheckedListBox()
        {
            InitializeComponent();
            checkedListBox.ItemCheck += (sender, e) => {
                _checkedListBoxSelectedElementChoose?.Invoke(sender, e);
            };
        }

        /// <summary>
        /// Заполнение списка значениями из листа
        /// </summary>
        /// <param name="type">тип-справочник</param>
        public void LoadList(List<string> elements)
        {
            elements.ForEach(element => checkedListBox.Items.Add(element));
        }
    }
}

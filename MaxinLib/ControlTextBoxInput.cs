using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace MaxinLib
{
    public partial class ControlTextBoxInput : UserControl
    {
        private event EventHandler _textBoxChange;
        private event EventHandler _checkBoxChange;
        public ControlTextBoxInput()
        {
            InitializeComponent();

            textBox.TextChanged += (sender, e) =>
            {
                _textBoxChange?.Invoke(sender, e);
            };

            checkBox.CheckStateChanged += (sender, e) =>
            {
                _checkBoxChange?.Invoke(sender, e);
            };
        }

        [Category("Спецификация"), Description("Текст в поле")]
        public int? TextBoxValue
        {
            get; set;
        }

        public bool IsChecked 
        {
            get => checkBox.Checked;
            set
            {
                checkBox.Checked = value;
                textBox.ReadOnly = value;

                if (value)
                {
                    textBox.Text = null;
                }
            }
        }

        [Category("Спецификация"), Description("Событие изменения текста")]
        public event EventHandler TextBoxChange
        {
            add => _textBoxChange += value;
            remove => _textBoxChange -= value;
        }

        [Category("Спецификация"), Description("Событие изменения чекбокса")]
        public event EventHandler CheckBoxChange
        {
            add => _checkBoxChange += value;
            remove => _checkBoxChange -= value;
        }

        private void TextBox_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textBox.Text))
            {
                int number;
                bool success = int.TryParse(textBox.Text, out number);

                if (success)
                {
                    TextBoxValue = number;
                    labelError.Text = "";
                }
                else
                {
                    TextBoxValue = null;
                    labelError.Text = "Ввод некорректный";
                }
            }
            else
            {
                TextBoxValue = null;
                labelError.Text = "Поле не заполнено";
            }
        }

        private void CheckBox_CheckedChanged(object sender, EventArgs e)
        {
            IsChecked = checkBox.Checked;
        }
    }
}

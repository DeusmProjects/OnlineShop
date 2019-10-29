namespace SharafutdinovaForm
{
    partial class FormTest
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonChange = new System.Windows.Forms.Button();
            this.dataTimePickerWithRange1 = new SharafutdinovaLib.DataTimePickerWithRange();
            this.comboBoxSelected = new SharafutdinovaLib.ComboBoxSelected();
            this.valueTable1 = new SharafutdinovaLib.ValueTable();
            this.SuspendLayout();
            // 
            // buttonChange
            // 
            this.buttonChange.Location = new System.Drawing.Point(137, 78);
            this.buttonChange.Name = "buttonChange";
            this.buttonChange.Size = new System.Drawing.Size(127, 23);
            this.buttonChange.TabIndex = 1;
            this.buttonChange.Text = "Сменить номер";
            this.buttonChange.UseVisualStyleBackColor = true;
            this.buttonChange.Click += new System.EventHandler(this.buttonChange_Click);
            // 
            // dataTimePickerWithRange1
            // 
            this.dataTimePickerWithRange1.Location = new System.Drawing.Point(58, 125);
            this.dataTimePickerWithRange1.MaxDate = "18.10.2019";
            this.dataTimePickerWithRange1.MinValue = "12.09.2019";
            this.dataTimePickerWithRange1.Name = "dataTimePickerWithRange1";
            this.dataTimePickerWithRange1.Size = new System.Drawing.Size(233, 27);
            this.dataTimePickerWithRange1.TabIndex = 2;
            // 
            // comboBoxSelected
            // 
            this.comboBoxSelected.Location = new System.Drawing.Point(44, 12);
            this.comboBoxSelected.Name = "comboBoxSelected";
            this.comboBoxSelected.SelectedIndex = 0;
            this.comboBoxSelected.Size = new System.Drawing.Size(294, 27);
            this.comboBoxSelected.TabIndex = 0;
            this.comboBoxSelected.ComboBoxSelectedElementChange += new System.EventHandler(this.controlComboBoxSelected_ComboBoxSelectedElementChange);
            // 
            // valueTable1
            // 
            this.valueTable1.Location = new System.Drawing.Point(12, 187);
            this.valueTable1.Name = "valueTable1";
            this.valueTable1.Size = new System.Drawing.Size(606, 401);
            this.valueTable1.TabIndex = 3;
            this.valueTable1.Load += new System.EventHandler(this.valueTable1_Load);
            // 
            // FormTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(721, 623);
            this.Controls.Add(this.valueTable1);
            this.Controls.Add(this.dataTimePickerWithRange1);
            this.Controls.Add(this.buttonChange);
            this.Controls.Add(this.comboBoxSelected);
            this.Name = "FormTest";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private SharafutdinovaLib.ComboBoxSelected comboBoxSelected;
        private System.Windows.Forms.Button buttonChange;
        private SharafutdinovaLib.DataTimePickerWithRange dataTimePickerWithRange1;
        private SharafutdinovaLib.ValueTable valueTable1;
    }
}


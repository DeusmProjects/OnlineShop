namespace TestForm
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.buttonCreateReport = new System.Windows.Forms.Button();
            this.buttonCreateDiagram = new System.Windows.Forms.Button();
            this.controlListBoxView2 = new MaxinLib.ControlListBoxView();
            this.controlListBoxView1 = new MaxinLib.ControlListBoxView();
            this.controlTextBoxInput1 = new MaxinLib.ControlTextBoxInput();
            this.controlListBoxSelected1 = new MaxinLib.ControlListBoxSelected();
            this.excelReport = new MaxinLib.ExcelReport(this.components);
            this.wordDiagram = new MaxinLib.WordDiagram(this.components);
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(9, 168);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(81, 19);
            this.button1.TabIndex = 1;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(9, 279);
            this.button2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(81, 19);
            this.button2.TabIndex = 3;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // buttonCreateReport
            // 
            this.buttonCreateReport.Location = new System.Drawing.Point(531, 37);
            this.buttonCreateReport.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonCreateReport.Name = "buttonCreateReport";
            this.buttonCreateReport.Size = new System.Drawing.Size(122, 28);
            this.buttonCreateReport.TabIndex = 5;
            this.buttonCreateReport.Text = "Создать отчет";
            this.buttonCreateReport.UseVisualStyleBackColor = true;
            this.buttonCreateReport.Click += new System.EventHandler(this.ButtonCreateReport_Click);
            // 
            // buttonCreateDiagram
            // 
            this.buttonCreateDiagram.Location = new System.Drawing.Point(531, 103);
            this.buttonCreateDiagram.Name = "buttonCreateDiagram";
            this.buttonCreateDiagram.Size = new System.Drawing.Size(122, 29);
            this.buttonCreateDiagram.TabIndex = 6;
            this.buttonCreateDiagram.Text = "Создать диаграму";
            this.buttonCreateDiagram.UseVisualStyleBackColor = true;
            this.buttonCreateDiagram.Click += new System.EventHandler(this.ButtonCreateDiagram_Click);
            // 
            // controlListBoxView2
            // 
            this.controlListBoxView2.Location = new System.Drawing.Point(471, 213);
            this.controlListBoxView2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.controlListBoxView2.Name = "controlListBoxView2";
            this.controlListBoxView2.Pattern = null;
            this.controlListBoxView2.SelectedIndex = -1;
            this.controlListBoxView2.Size = new System.Drawing.Size(374, 184);
            this.controlListBoxView2.TabIndex = 7;
            // 
            // controlListBoxView1
            // 
            this.controlListBoxView1.Location = new System.Drawing.Point(9, 308);
            this.controlListBoxView1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.controlListBoxView1.Name = "controlListBoxView1";
            this.controlListBoxView1.Pattern = null;
            this.controlListBoxView1.SelectedIndex = -1;
            this.controlListBoxView1.Size = new System.Drawing.Size(374, 184);
            this.controlListBoxView1.TabIndex = 4;
            // 
            // controlTextBoxInput1
            // 
            this.controlTextBoxInput1.IsChecked = false;
            this.controlTextBoxInput1.Location = new System.Drawing.Point(9, 211);
            this.controlTextBoxInput1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.controlTextBoxInput1.Name = "controlTextBoxInput1";
            this.controlTextBoxInput1.Size = new System.Drawing.Size(215, 43);
            this.controlTextBoxInput1.TabIndex = 2;
            this.controlTextBoxInput1.TextBoxValue = null;
            this.controlTextBoxInput1.TextBoxChange += new System.EventHandler(this.controlTextBoxInput_CheckBoxChange);
            this.controlTextBoxInput1.CheckBoxChange += new System.EventHandler(this.ControlTextBoxInput1_CheckBoxChange);
            // 
            // controlListBoxSelected1
            // 
            this.controlListBoxSelected1.Location = new System.Drawing.Point(9, 37);
            this.controlListBoxSelected1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.controlListBoxSelected1.Name = "controlListBoxSelected1";
            this.controlListBoxSelected1.SelectedIndex = -1;
            this.controlListBoxSelected1.Size = new System.Drawing.Size(391, 127);
            this.controlListBoxSelected1.TabIndex = 0;
            this.controlListBoxSelected1.ListBoxSelectedElementChange += new System.EventHandler(this.controlListBoxSelected_ListBoxSelectedElementChange);
            // 
            // excelReport
            // 
            this.excelReport.Header = null;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(899, 507);
            this.Controls.Add(this.controlListBoxView2);
            this.Controls.Add(this.buttonCreateDiagram);
            this.Controls.Add(this.buttonCreateReport);
            this.Controls.Add(this.controlListBoxView1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.controlTextBoxInput1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.controlListBoxSelected1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private MaxinLib.ControlListBoxSelected controlListBoxSelected1;
        private System.Windows.Forms.Button button1;
        private MaxinLib.ControlTextBoxInput controlTextBoxInput1;
        private System.Windows.Forms.Button button2;
        private MaxinLib.ControlListBoxView controlListBoxView1;
        private MaxinLib.ExcelReport excelReport;
        private System.Windows.Forms.Button buttonCreateReport;
        private System.Windows.Forms.Button buttonCreateDiagram;
        private MaxinLib.ControlListBoxView controlListBoxView2;
        private MaxinLib.WordDiagram wordDiagram;
    }
}


namespace WindowsFormsAnikyev
{
    partial class TestForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.buttonChangingChoosed = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.controlTreeView1 = new AnikyevLib.ControlTreeView();
            this.controlTextBoxEmail1 = new AnikyevLib.ControlTextBoxEmail();
            this.controlCheckedListBox1 = new AnikyevLib.ControlCheckedListBox();
            this.button2 = new System.Windows.Forms.Button();
            this.componentCreateBackup1 = new AnikyevLibNotVisual.ComponentCreateBackup(this.components);
            this.componentExportDiagram1 = new AnikyevLibNotVisual.ComponentExportDiagram(this.components);
            this.componentExportReport1 = new AnikyevLibNotVisual.ComponentExportReport(this.components);
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonChangingChoosed
            // 
            this.buttonChangingChoosed.Location = new System.Drawing.Point(46, 183);
            this.buttonChangingChoosed.Name = "buttonChangingChoosed";
            this.buttonChangingChoosed.Size = new System.Drawing.Size(225, 23);
            this.buttonChangingChoosed.TabIndex = 1;
            this.buttonChangingChoosed.Text = "Сменить выбранные";
            this.buttonChangingChoosed.UseVisualStyleBackColor = true;
            this.buttonChangingChoosed.Click += new System.EventHandler(this.buttonChangingChoosed_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 276);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(123, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Серилизовать";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // controlTreeView1
            // 
            this.controlTreeView1.Location = new System.Drawing.Point(349, 12);
            this.controlTreeView1.Name = "controlTreeView1";
            this.controlTreeView1.Size = new System.Drawing.Size(243, 207);
            this.controlTreeView1.TabIndex = 3;
            // 
            // controlTextBoxEmail1
            // 
            this.controlTextBoxEmail1.EmailText = null;
            this.controlTextBoxEmail1.Location = new System.Drawing.Point(12, 234);
            this.controlTextBoxEmail1.MaximumSize = new System.Drawing.Size(1000, 23);
            this.controlTextBoxEmail1.Name = "controlTextBoxEmail1";
            this.controlTextBoxEmail1.Size = new System.Drawing.Size(297, 23);
            this.controlTextBoxEmail1.TabIndex = 2;
            // 
            // controlCheckedListBox1
            // 
            this.controlCheckedListBox1.CheckedIndeces = null;
            this.controlCheckedListBox1.Location = new System.Drawing.Point(12, 12);
            this.controlCheckedListBox1.Name = "controlCheckedListBox1";
            this.controlCheckedListBox1.Size = new System.Drawing.Size(297, 165);
            this.controlCheckedListBox1.TabIndex = 0;
            this.controlCheckedListBox1.CheckedListBoxSelectedElementChoose += new System.EventHandler(this.controlCheckedListBoxSelected_CheckedListBoxSelectedElementsChange);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(141, 276);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(173, 23);
            this.button2.TabIndex = 5;
            this.button2.Text = "Экспорт диаграммы";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // componentCreateBackup1
            // 
            this.componentCreateBackup1.OutputPath = null;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(321, 276);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(163, 23);
            this.button3.TabIndex = 6;
            this.button3.Text = "Экспорт отчета";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // TestForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(620, 316);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.controlTreeView1);
            this.Controls.Add(this.controlTextBoxEmail1);
            this.Controls.Add(this.buttonChangingChoosed);
            this.Controls.Add(this.controlCheckedListBox1);
            this.Name = "TestForm";
            this.Text = "TestForm";
            this.ResumeLayout(false);

        }

        #endregion

        private AnikyevLib.ControlCheckedListBox controlCheckedListBox1;
        private System.Windows.Forms.Button buttonChangingChoosed;
        private AnikyevLib.ControlTextBoxEmail controlTextBoxEmail1;
        private AnikyevLib.ControlTreeView controlTreeView1;
        private AnikyevLibNotVisual.ComponentCreateBackup componentCreateBackup1;
        private System.Windows.Forms.Button button1;
        private AnikyevLibNotVisual.ComponentExportDiagram componentExportDiagram1;
        private System.Windows.Forms.Button button2;
        private AnikyevLibNotVisual.ComponentExportReport componentExportReport1;
        private System.Windows.Forms.Button button3;
    }
}
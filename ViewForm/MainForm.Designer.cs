namespace ViewForm
{
    partial class MainForm
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
            this.comboBoxSelected1 = new SharafutdinovaLib.ComboBoxSelected();
            this.controlTextBoxInput1 = new MaxinLib.ControlTextBoxInput();
            this.buttonCreate = new System.Windows.Forms.Button();
            this.buttonRemove = new System.Windows.Forms.Button();
            this.controlTreeView1 = new AnikyevLib.ControlTreeView();
            this.wordDiagram1 = new MaxinLib.WordDiagram(this.components);
            this.componentCreateBackup1 = new AnikyevLibNotVisual.ComponentCreateBackup(this.components);
            this.wordReport1 = new SharafutdinovaLibNotVisual.WordReport(this.components);
            this.buttonCreateBackup = new System.Windows.Forms.Button();
            this.buttonWordReport = new System.Windows.Forms.Button();
            this.buttonWordDiagram = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // comboBoxSelected1
            // 
            this.comboBoxSelected1.Location = new System.Drawing.Point(463, 12);
            this.comboBoxSelected1.Name = "comboBoxSelected1";
            this.comboBoxSelected1.SelectedIndex = 0;
            this.comboBoxSelected1.Size = new System.Drawing.Size(294, 27);
            this.comboBoxSelected1.TabIndex = 1;
            // 
            // controlTextBoxInput1
            // 
            this.controlTextBoxInput1.IsChecked = false;
            this.controlTextBoxInput1.Location = new System.Drawing.Point(463, 45);
            this.controlTextBoxInput1.Name = "controlTextBoxInput1";
            this.controlTextBoxInput1.Size = new System.Drawing.Size(287, 58);
            this.controlTextBoxInput1.TabIndex = 2;
            this.controlTextBoxInput1.TextBoxValue = null;
            // 
            // buttonCreate
            // 
            this.buttonCreate.Location = new System.Drawing.Point(463, 109);
            this.buttonCreate.Name = "buttonCreate";
            this.buttonCreate.Size = new System.Drawing.Size(294, 23);
            this.buttonCreate.TabIndex = 3;
            this.buttonCreate.Text = " Создать";
            this.buttonCreate.UseVisualStyleBackColor = true;
            this.buttonCreate.Click += new System.EventHandler(this.buttonCreate_Click);
            // 
            // buttonRemove
            // 
            this.buttonRemove.Location = new System.Drawing.Point(463, 138);
            this.buttonRemove.Name = "buttonRemove";
            this.buttonRemove.Size = new System.Drawing.Size(294, 23);
            this.buttonRemove.TabIndex = 4;
            this.buttonRemove.Text = "Удалить";
            this.buttonRemove.UseVisualStyleBackColor = true;
            this.buttonRemove.Click += new System.EventHandler(this.buttonRemove_Click);
            // 
            // controlTreeView1
            // 
            this.controlTreeView1.Location = new System.Drawing.Point(12, 12);
            this.controlTreeView1.Name = "controlTreeView1";
            this.controlTreeView1.Size = new System.Drawing.Size(445, 426);
            this.controlTreeView1.TabIndex = 0;
            // 
            // wordDiagram1
            // 
            this.wordDiagram1.Data = null;
            this.wordDiagram1.DiagramName = null;
            this.wordDiagram1.Name = null;
            this.wordDiagram1.Value = null;
            // 
            // componentCreateBackup1
            // 
            this.componentCreateBackup1.OutputPath = null;
            // 
            // buttonCreateBackup
            // 
            this.buttonCreateBackup.Location = new System.Drawing.Point(463, 335);
            this.buttonCreateBackup.Name = "buttonCreateBackup";
            this.buttonCreateBackup.Size = new System.Drawing.Size(294, 23);
            this.buttonCreateBackup.TabIndex = 5;
            this.buttonCreateBackup.Text = "Создать бекап";
            this.buttonCreateBackup.UseVisualStyleBackColor = true;
            this.buttonCreateBackup.Click += new System.EventHandler(this.buttonCreateBackup_Click);
            // 
            // buttonWordReport
            // 
            this.buttonWordReport.Location = new System.Drawing.Point(463, 365);
            this.buttonWordReport.Name = "buttonWordReport";
            this.buttonWordReport.Size = new System.Drawing.Size(294, 23);
            this.buttonWordReport.TabIndex = 6;
            this.buttonWordReport.Text = "Отчет в формате Word";
            this.buttonWordReport.UseVisualStyleBackColor = true;
            this.buttonWordReport.Click += new System.EventHandler(this.buttonWordReport_Click);
            // 
            // buttonWordDiagram
            // 
            this.buttonWordDiagram.Location = new System.Drawing.Point(464, 395);
            this.buttonWordDiagram.Name = "buttonWordDiagram";
            this.buttonWordDiagram.Size = new System.Drawing.Size(293, 23);
            this.buttonWordDiagram.TabIndex = 7;
            this.buttonWordDiagram.Text = "Диаграмма в формате Word";
            this.buttonWordDiagram.UseVisualStyleBackColor = true;
            this.buttonWordDiagram.Click += new System.EventHandler(this.buttonWordDiagram_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(774, 450);
            this.Controls.Add(this.buttonWordDiagram);
            this.Controls.Add(this.buttonWordReport);
            this.Controls.Add(this.buttonCreateBackup);
            this.Controls.Add(this.buttonRemove);
            this.Controls.Add(this.buttonCreate);
            this.Controls.Add(this.controlTextBoxInput1);
            this.Controls.Add(this.comboBoxSelected1);
            this.Controls.Add(this.controlTreeView1);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.ResumeLayout(false);

        }

        #endregion

        private AnikyevLib.ControlTreeView controlTreeView1;
        private SharafutdinovaLib.ComboBoxSelected comboBoxSelected1;
        private MaxinLib.ControlTextBoxInput controlTextBoxInput1;
        private System.Windows.Forms.Button buttonCreate;
        private System.Windows.Forms.Button buttonRemove;
        private MaxinLib.WordDiagram wordDiagram1;
        private AnikyevLibNotVisual.ComponentCreateBackup componentCreateBackup1;
        private SharafutdinovaLibNotVisual.WordReport wordReport1;
        private System.Windows.Forms.Button buttonCreateBackup;
        private System.Windows.Forms.Button buttonWordReport;
        private System.Windows.Forms.Button buttonWordDiagram;
    }
}
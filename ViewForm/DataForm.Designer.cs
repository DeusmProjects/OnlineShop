namespace ViewForm
{
    partial class DataForm
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.загрузкаДанныхToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.диаграммаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.отчетToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.excelReport1 = new MaxinLib.ExcelReport(this.components);
            this.componentExportDiagram1 = new AnikyevLibNotVisual.ComponentExportDiagram(this.components);
            this.dataLoading1 = new SharafutdinovaLibNotVisual.DataLoading(this.components);
            this.valueTable1 = new SharafutdinovaLib.ValueTable();
            this.buttonCreate = new System.Windows.Forms.Button();
            this.созданиеБэкапаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.componentCreateBackup1 = new AnikyevLibNotVisual.ComponentCreateBackup(this.components);
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.загрузкаДанныхToolStripMenuItem,
            this.диаграммаToolStripMenuItem,
            this.отчетToolStripMenuItem,
            this.созданиеБэкапаToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // загрузкаДанныхToolStripMenuItem
            // 
            this.загрузкаДанныхToolStripMenuItem.Name = "загрузкаДанныхToolStripMenuItem";
            this.загрузкаДанныхToolStripMenuItem.Size = new System.Drawing.Size(137, 24);
            this.загрузкаДанныхToolStripMenuItem.Text = "Загрузка данных";
            this.загрузкаДанныхToolStripMenuItem.Click += new System.EventHandler(this.загрузкаДанныхToolStripMenuItem_Click);
            // 
            // диаграммаToolStripMenuItem
            // 
            this.диаграммаToolStripMenuItem.Name = "диаграммаToolStripMenuItem";
            this.диаграммаToolStripMenuItem.Size = new System.Drawing.Size(101, 24);
            this.диаграммаToolStripMenuItem.Text = "Диаграмма";
            this.диаграммаToolStripMenuItem.Click += new System.EventHandler(this.диаграммаToolStripMenuItem_Click);
            // 
            // отчетToolStripMenuItem
            // 
            this.отчетToolStripMenuItem.Name = "отчетToolStripMenuItem";
            this.отчетToolStripMenuItem.Size = new System.Drawing.Size(60, 24);
            this.отчетToolStripMenuItem.Text = "Отчет";
            this.отчетToolStripMenuItem.Click += new System.EventHandler(this.отчетToolStripMenuItem_Click);
            // 
            // excelReport1
            // 
            this.excelReport1.Header = null;
            // 
            // valueTable1
            // 
            this.valueTable1.Location = new System.Drawing.Point(12, 37);
            this.valueTable1.Name = "valueTable1";
            this.valueTable1.Size = new System.Drawing.Size(617, 401);
            this.valueTable1.TabIndex = 1;
            // 
            // buttonCreate
            // 
            this.buttonCreate.Location = new System.Drawing.Point(655, 65);
            this.buttonCreate.Name = "buttonCreate";
            this.buttonCreate.Size = new System.Drawing.Size(98, 34);
            this.buttonCreate.TabIndex = 2;
            this.buttonCreate.Text = "Создать";
            this.buttonCreate.UseVisualStyleBackColor = true;
            this.buttonCreate.Click += new System.EventHandler(this.buttonCreate_Click);
            // 
            // созданиеБэкапаToolStripMenuItem
            // 
            this.созданиеБэкапаToolStripMenuItem.Name = "созданиеБэкапаToolStripMenuItem";
            this.созданиеБэкапаToolStripMenuItem.Size = new System.Drawing.Size(140, 24);
            this.созданиеБэкапаToolStripMenuItem.Text = "Создание бэкапа";
            this.созданиеБэкапаToolStripMenuItem.Click += new System.EventHandler(this.созданиеБэкапаToolStripMenuItem_Click);
            // 
            // componentCreateBackup1
            // 
            this.componentCreateBackup1.OutputPath = null;
            // 
            // DataForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonCreate);
            this.Controls.Add(this.valueTable1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "DataForm";
            this.Text = "DataForm";
            this.Load += new System.EventHandler(this.Main_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem загрузкаДанныхToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem диаграммаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem отчетToolStripMenuItem;
        private MaxinLib.ExcelReport excelReport1;
        private AnikyevLibNotVisual.ComponentExportDiagram componentExportDiagram1;
        private SharafutdinovaLibNotVisual.DataLoading dataLoading1;
        private SharafutdinovaLib.ValueTable valueTable1;
        private System.Windows.Forms.Button buttonCreate;
        private System.Windows.Forms.ToolStripMenuItem созданиеБэкапаToolStripMenuItem;
        private AnikyevLibNotVisual.ComponentCreateBackup componentCreateBackup1;
    }
}
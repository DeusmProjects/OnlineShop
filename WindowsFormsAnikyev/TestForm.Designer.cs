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
            this.buttonChangingChoosed = new System.Windows.Forms.Button();
            this.controlTextBoxEmail1 = new AnikyevLib.ControlTextBoxEmail();
            this.controlCheckedListBox1 = new AnikyevLib.ControlCheckedListBox();
            this.controlTreeView1 = new AnikyevLib.ControlTreeView();
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
            // controlTextBoxEmail1
            // 
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
            // controlTreeView1
            // 
            this.controlTreeView1.Location = new System.Drawing.Point(349, 12);
            this.controlTreeView1.Name = "controlTreeView1";
            this.controlTreeView1.Size = new System.Drawing.Size(243, 207);
            this.controlTreeView1.TabIndex = 3;
            // 
            // TestForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(616, 278);
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
    }
}
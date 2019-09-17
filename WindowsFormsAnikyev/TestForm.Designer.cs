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
            this.controlCheckedListBoxSelected1 = new AnikyevLib.ControlCheckedListBoxSelected();
            this.SuspendLayout();
            // 
            // buttonChangingChoosed
            // 
            this.buttonChangingChoosed.Location = new System.Drawing.Point(28, 292);
            this.buttonChangingChoosed.Name = "buttonChangingChoosed";
            this.buttonChangingChoosed.Size = new System.Drawing.Size(225, 23);
            this.buttonChangingChoosed.TabIndex = 1;
            this.buttonChangingChoosed.Text = "Сменить выбранные";
            this.buttonChangingChoosed.UseVisualStyleBackColor = true;
            this.buttonChangingChoosed.Click += new System.EventHandler(this.buttonChangingChoosed_Click);
            // 
            // controlCheckedListBoxSelected1
            // 
            this.controlCheckedListBoxSelected1.CheckedIndeces = null;
            this.controlCheckedListBoxSelected1.Location = new System.Drawing.Point(12, 12);
            this.controlCheckedListBoxSelected1.Name = "controlCheckedListBoxSelected1";
            this.controlCheckedListBoxSelected1.Size = new System.Drawing.Size(297, 165);
            this.controlCheckedListBoxSelected1.TabIndex = 0;
            this.controlCheckedListBoxSelected1.CheckedListBoxSelectedElementChoose += new System.EventHandler(this.controlCheckedListBoxSelected_CheckedListBoxSelectedElementsChange);
            // 
            // TestForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(345, 365);
            this.Controls.Add(this.buttonChangingChoosed);
            this.Controls.Add(this.controlCheckedListBoxSelected1);
            this.Name = "TestForm";
            this.Text = "TestForm";
            this.ResumeLayout(false);

        }

        #endregion

        private AnikyevLib.ControlCheckedListBoxSelected controlCheckedListBoxSelected1;
        private System.Windows.Forms.Button buttonChangingChoosed;
    }
}
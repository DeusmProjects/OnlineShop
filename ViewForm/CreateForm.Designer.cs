namespace ViewForm
{
    partial class CreateForm
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
            this.controlListBoxSelected1 = new MaxinLib.ControlListBoxSelected();
            this.label1 = new System.Windows.Forms.Label();
            this.controlTextBoxEmail1 = new AnikyevLib.ControlTextBoxEmail();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // controlListBoxSelected1
            // 
            this.controlListBoxSelected1.Location = new System.Drawing.Point(11, 42);
            this.controlListBoxSelected1.Name = "controlListBoxSelected1";
            this.controlListBoxSelected1.SelectedIndex = -1;
            this.controlListBoxSelected1.Size = new System.Drawing.Size(404, 150);
            this.controlListBoxSelected1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Город назначения";
            // 
            // controlTextBoxEmail1
            // 
            this.controlTextBoxEmail1.EmailText = null;
            this.controlTextBoxEmail1.Location = new System.Drawing.Point(16, 225);
            this.controlTextBoxEmail1.MaximumSize = new System.Drawing.Size(1000, 23);
            this.controlTextBoxEmail1.Name = "controlTextBoxEmail1";
            this.controlTextBoxEmail1.Size = new System.Drawing.Size(200, 23);
            this.controlTextBoxEmail1.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 199);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(138, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Электронная почта";
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(58, 294);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(117, 23);
            this.buttonSave.TabIndex = 4;
            this.buttonSave.Text = "Сохранить";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(213, 294);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(100, 23);
            this.buttonCancel.TabIndex = 5;
            this.buttonCancel.Text = "Отмена";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // CreateForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(427, 362);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.controlTextBoxEmail1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.controlListBoxSelected1);
            this.Name = "CreateForm";
            this.Text = "CreateForm";
            this.Load += new System.EventHandler(this.CreateForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaxinLib.ControlListBoxSelected controlListBoxSelected1;
        private System.Windows.Forms.Label label1;
        private AnikyevLib.ControlTextBoxEmail controlTextBoxEmail1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonCancel;
    }
}
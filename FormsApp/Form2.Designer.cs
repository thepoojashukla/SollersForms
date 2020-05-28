namespace FormsApp
{
    partial class Form2
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
            this.BtnTimeConsumingWork = new System.Windows.Forms.Button();
            this.BtnPrintNumbers = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // BtnTimeConsumingWork
            // 
            this.BtnTimeConsumingWork.Location = new System.Drawing.Point(188, 45);
            this.BtnTimeConsumingWork.Name = "BtnTimeConsumingWork";
            this.BtnTimeConsumingWork.Size = new System.Drawing.Size(453, 51);
            this.BtnTimeConsumingWork.TabIndex = 0;
            this.BtnTimeConsumingWork.Text = "Do Time Consuming Work";
            this.BtnTimeConsumingWork.UseVisualStyleBackColor = true;
            this.BtnTimeConsumingWork.Click += new System.EventHandler(this.BtnTimeConsumingWork_Click);
            // 
            // BtnPrintNumbers
            // 
            this.BtnPrintNumbers.Location = new System.Drawing.Point(188, 133);
            this.BtnPrintNumbers.Name = "BtnPrintNumbers";
            this.BtnPrintNumbers.Size = new System.Drawing.Size(453, 57);
            this.BtnPrintNumbers.TabIndex = 1;
            this.BtnPrintNumbers.Text = "Print Numbers";
            this.BtnPrintNumbers.UseVisualStyleBackColor = true;
            this.BtnPrintNumbers.Click += new System.EventHandler(this.BtnPrintNumbers_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 31;
            this.listBox1.Location = new System.Drawing.Point(188, 286);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(515, 407);
            this.listBox1.TabIndex = 2;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(969, 743);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.BtnPrintNumbers);
            this.Controls.Add(this.BtnTimeConsumingWork);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnTimeConsumingWork;
        private System.Windows.Forms.Button BtnPrintNumbers;
        private System.Windows.Forms.ListBox listBox1;
    }
}
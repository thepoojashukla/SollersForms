namespace FormsApp
{
    partial class Form1
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
            this.ClickMeButton = new System.Windows.Forms.Button();
            this.CountryDropdown = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // ClickMeButton
            // 
            this.ClickMeButton.Location = new System.Drawing.Point(151, 300);
            this.ClickMeButton.Name = "ClickMeButton";
            this.ClickMeButton.Size = new System.Drawing.Size(202, 70);
            this.ClickMeButton.TabIndex = 0;
            this.ClickMeButton.Text = "Click me";
            this.ClickMeButton.UseVisualStyleBackColor = true;
            this.ClickMeButton.Click += new System.EventHandler(this.ClickMeButton_Click);
            // 
            // CountryDropdown
            // 
            this.CountryDropdown.FormattingEnabled = true;
            this.CountryDropdown.Location = new System.Drawing.Point(151, 98);
            this.CountryDropdown.Name = "CountryDropdown";
            this.CountryDropdown.Size = new System.Drawing.Size(255, 39);
            this.CountryDropdown.TabIndex = 1;
            this.CountryDropdown.Text = "Country";
            this.CountryDropdown.SelectedIndexChanged += new System.EventHandler(this.CountryDropdown_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.CountryDropdown);
            this.Controls.Add(this.ClickMeButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ClickMeButton;
        private System.Windows.Forms.ComboBox CountryDropdown;
    }
}


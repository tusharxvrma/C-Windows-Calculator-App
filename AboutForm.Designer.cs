namespace CalculatorPRG
{
    partial class AboutForm
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
            this.txtBoxAbout1 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtBoxAbout1
            // 
            this.txtBoxAbout1.BackColor = System.Drawing.Color.Black;
            this.txtBoxAbout1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxAbout1.ForeColor = System.Drawing.Color.IndianRed;
            this.txtBoxAbout1.Location = new System.Drawing.Point(1, 105);
            this.txtBoxAbout1.Multiline = true;
            this.txtBoxAbout1.Name = "txtBoxAbout1";
            this.txtBoxAbout1.Size = new System.Drawing.Size(1114, 525);
            this.txtBoxAbout1.TabIndex = 0;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.Black;
            this.textBox1.Font = new System.Drawing.Font("Palatino Linotype", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.Color.IndianRed;
            this.textBox1.Location = new System.Drawing.Point(202, 14);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(749, 85);
            this.textBox1.TabIndex = 1;
            this.textBox1.Text = "Not sure how the Calculator works? Here is your guide!";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // AboutForm
            // 
            this.BackgroundImage = global::CalculatorPRG.Properties.Resources.R__1_;
            this.ClientSize = new System.Drawing.Size(1117, 631);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.txtBoxAbout1);
            this.Name = "AboutForm";
            this.Text = "About";
            this.Load += new System.EventHandler(this.AboutForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBoxAbout;
        private System.Windows.Forms.TextBox txtBoxAbout1;
        private System.Windows.Forms.TextBox textBox1;
    }
}
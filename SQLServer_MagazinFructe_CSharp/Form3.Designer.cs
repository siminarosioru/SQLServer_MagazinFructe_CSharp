
namespace SQLServer_MagazinFructe_CSharp
{
    partial class Form3
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
            this.lblAngajat = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblAngajat
            // 
            this.lblAngajat.AutoSize = true;
            this.lblAngajat.BackColor = System.Drawing.SystemColors.Highlight;
            this.lblAngajat.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblAngajat.Location = new System.Drawing.Point(119, 112);
            this.lblAngajat.Name = "lblAngajat";
            this.lblAngajat.Size = new System.Drawing.Size(126, 20);
            this.lblAngajat.TabIndex = 0;
            this.lblAngajat.Text = "simple employee";
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblAngajat);
            this.Name = "Form3";
            this.Text = "Form3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAngajat;
    }
}
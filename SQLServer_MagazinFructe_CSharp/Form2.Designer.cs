﻿
namespace SQLServer_MagazinFructe_CSharp
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
            this.lblForm2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblForm2
            // 
            this.lblForm2.AutoSize = true;
            this.lblForm2.BackColor = System.Drawing.SystemColors.Highlight;
            this.lblForm2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblForm2.Location = new System.Drawing.Point(139, 109);
            this.lblForm2.Name = "lblForm2";
            this.lblForm2.Size = new System.Drawing.Size(119, 20);
            this.lblForm2.TabIndex = 0;
            this.lblForm2.Text = "admin is logged";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblForm2);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblForm2;
    }
}
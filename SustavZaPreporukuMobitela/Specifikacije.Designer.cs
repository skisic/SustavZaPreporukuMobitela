﻿
namespace SustavZaPreporukuMobitela
{
    partial class Specifikacije
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
            this.lab_key = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lab_key
            // 
            this.lab_key.AutoSize = true;
            this.lab_key.Location = new System.Drawing.Point(12, 30);
            this.lab_key.Name = "lab_key";
            this.lab_key.Size = new System.Drawing.Size(24, 13);
            this.lab_key.TabIndex = 0;
            this.lab_key.Text = "test";
            // 
            // Specifikacije
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(254, 450);
            this.Controls.Add(this.lab_key);
            this.Name = "Specifikacije";
            this.Text = "Specifikacije";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lab_key;
    }
}
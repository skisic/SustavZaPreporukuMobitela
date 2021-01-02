
namespace SustavZaPreporukuMobitela
{
    partial class Zadnja
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.btn_preporuci = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.pictureBox_mob1 = new System.Windows.Forms.PictureBox();
            this.label_mobileName1 = new System.Windows.Forms.Label();
            this.btn_spec1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_mob1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(278, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Zadnja forma";
            // 
            // btn_preporuci
            // 
            this.btn_preporuci.Location = new System.Drawing.Point(234, 64);
            this.btn_preporuci.Name = "btn_preporuci";
            this.btn_preporuci.Size = new System.Drawing.Size(146, 23);
            this.btn_preporuci.TabIndex = 1;
            this.btn_preporuci.Text = "Preporuči mobitel";
            this.btn_preporuci.UseVisualStyleBackColor = true;
            this.btn_preporuci.Click += new System.EventHandler(this.btn_preporuci_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(71, 136);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Prijedlog br.1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(278, 136);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "mobitel_2";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(495, 136);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "mobitel_3";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(356, 308);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(239, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Prikazi specifikacije gumb(ako nam se bude dalo)";
            // 
            // pictureBox_mob1
            // 
            this.pictureBox_mob1.Location = new System.Drawing.Point(74, 152);
            this.pictureBox_mob1.Name = "pictureBox_mob1";
            this.pictureBox_mob1.Size = new System.Drawing.Size(139, 159);
            this.pictureBox_mob1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox_mob1.TabIndex = 7;
            this.pictureBox_mob1.TabStop = false;
            // 
            // label_mobileName1
            // 
            this.label_mobileName1.AutoSize = true;
            this.label_mobileName1.Location = new System.Drawing.Point(71, 325);
            this.label_mobileName1.Name = "label_mobileName1";
            this.label_mobileName1.Size = new System.Drawing.Size(130, 13);
            this.label_mobileName1.TabIndex = 8;
            this.label_mobileName1.Text = "ime_mobitela (bude blank)";
            // 
            // btn_spec1
            // 
            this.btn_spec1.Location = new System.Drawing.Point(138, 288);
            this.btn_spec1.Name = "btn_spec1";
            this.btn_spec1.Size = new System.Drawing.Size(75, 23);
            this.btn_spec1.TabIndex = 9;
            this.btn_spec1.Text = "Specifikacije";
            this.btn_spec1.UseVisualStyleBackColor = true;
            this.btn_spec1.Click += new System.EventHandler(this.btn_spec1_Click);
            // 
            // Zadnja
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btn_spec1);
            this.Controls.Add(this.label_mobileName1);
            this.Controls.Add(this.pictureBox_mob1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_preporuci);
            this.Controls.Add(this.label1);
            this.Name = "Zadnja";
            this.Size = new System.Drawing.Size(634, 461);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_mob1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_preporuci;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pictureBox_mob1;
        private System.Windows.Forms.Label label_mobileName1;
        private System.Windows.Forms.Button btn_spec1;
    }
}

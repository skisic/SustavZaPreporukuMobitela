
namespace SustavZaPreporukuMobitela
{
    partial class Pitanje15
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
            this.radioModelStari = new System.Windows.Forms.RadioButton();
            this.radioModelNovi = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.radioModelSvejedno = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // radioModelStari
            // 
            this.radioModelStari.AutoSize = true;
            this.radioModelStari.Location = new System.Drawing.Point(34, 150);
            this.radioModelStari.Name = "radioModelStari";
            this.radioModelStari.Size = new System.Drawing.Size(107, 17);
            this.radioModelStari.TabIndex = 11;
            this.radioModelStari.TabStop = true;
            this.radioModelStari.Text = "Želim stariji model";
            this.radioModelStari.UseVisualStyleBackColor = true;
            // 
            // radioModelNovi
            // 
            this.radioModelNovi.AutoSize = true;
            this.radioModelNovi.Location = new System.Drawing.Point(34, 110);
            this.radioModelNovi.Name = "radioModelNovi";
            this.radioModelNovi.Size = new System.Drawing.Size(122, 17);
            this.radioModelNovi.TabIndex = 10;
            this.radioModelNovi.TabStop = true;
            this.radioModelNovi.Text = "Želim najnoviji model";
            this.radioModelNovi.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(30, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(523, 22);
            this.label1.TabIndex = 13;
            this.label1.Text = "Zelite li najnoviji mobitel ili u obzir dolaze i stariji modeli?";
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnBack.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnBack.Location = new System.Drawing.Point(280, 410);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(30, 30);
            this.btnBack.TabIndex = 17;
            this.btnBack.Text = "<";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnNext
            // 
            this.btnNext.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnNext.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNext.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNext.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnNext.Location = new System.Drawing.Point(316, 410);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(30, 30);
            this.btnNext.TabIndex = 16;
            this.btnNext.Text = ">";
            this.btnNext.UseVisualStyleBackColor = false;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // radioModelSvejedno
            // 
            this.radioModelSvejedno.AutoSize = true;
            this.radioModelSvejedno.Location = new System.Drawing.Point(34, 190);
            this.radioModelSvejedno.Name = "radioModelSvejedno";
            this.radioModelSvejedno.Size = new System.Drawing.Size(70, 17);
            this.radioModelSvejedno.TabIndex = 18;
            this.radioModelSvejedno.TabStop = true;
            this.radioModelSvejedno.Text = "Svejedno";
            this.radioModelSvejedno.UseVisualStyleBackColor = true;
            // 
            // Pitanje15
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Controls.Add(this.radioModelSvejedno);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.radioModelStari);
            this.Controls.Add(this.radioModelNovi);
            this.Name = "Pitanje15";
            this.Size = new System.Drawing.Size(634, 461);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.RadioButton radioModelStari;
        private System.Windows.Forms.RadioButton radioModelNovi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.RadioButton radioModelSvejedno;
    }
}

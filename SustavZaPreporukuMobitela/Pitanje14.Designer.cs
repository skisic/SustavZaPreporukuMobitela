
namespace SustavZaPreporukuMobitela
{
    partial class Pitanje14
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
            this.radioEdgeNe = new System.Windows.Forms.RadioButton();
            this.radioEdgeDa = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.radioEdgeSvejedno = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // radioEdgeNe
            // 
            this.radioEdgeNe.AutoSize = true;
            this.radioEdgeNe.Location = new System.Drawing.Point(34, 150);
            this.radioEdgeNe.Name = "radioEdgeNe";
            this.radioEdgeNe.Size = new System.Drawing.Size(39, 17);
            this.radioEdgeNe.TabIndex = 11;
            this.radioEdgeNe.TabStop = true;
            this.radioEdgeNe.Text = "Ne";
            this.radioEdgeNe.UseVisualStyleBackColor = true;
            // 
            // radioEdgeDa
            // 
            this.radioEdgeDa.AutoSize = true;
            this.radioEdgeDa.Location = new System.Drawing.Point(34, 110);
            this.radioEdgeDa.Name = "radioEdgeDa";
            this.radioEdgeDa.Size = new System.Drawing.Size(39, 17);
            this.radioEdgeDa.TabIndex = 10;
            this.radioEdgeDa.TabStop = true;
            this.radioEdgeDa.Text = "Da";
            this.radioEdgeDa.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(30, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(230, 22);
            this.label1.TabIndex = 13;
            this.label1.Text = "Zelite li zaobljeni ekran?";
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
            // radioEdgeSvejedno
            // 
            this.radioEdgeSvejedno.AutoSize = true;
            this.radioEdgeSvejedno.Location = new System.Drawing.Point(34, 190);
            this.radioEdgeSvejedno.Name = "radioEdgeSvejedno";
            this.radioEdgeSvejedno.Size = new System.Drawing.Size(70, 17);
            this.radioEdgeSvejedno.TabIndex = 18;
            this.radioEdgeSvejedno.TabStop = true;
            this.radioEdgeSvejedno.Text = "Svejedno";
            this.radioEdgeSvejedno.UseVisualStyleBackColor = true;
            // 
            // Pitanje14
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Controls.Add(this.radioEdgeSvejedno);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.radioEdgeNe);
            this.Controls.Add(this.radioEdgeDa);
            this.Name = "Pitanje14";
            this.Size = new System.Drawing.Size(634, 461);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.RadioButton radioEdgeNe;
        private System.Windows.Forms.RadioButton radioEdgeDa;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.RadioButton radioEdgeSvejedno;
    }
}

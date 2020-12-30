namespace SustavZaPreporukuMobitela
{
    partial class FormPocetna
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
            this.label1 = new System.Windows.Forms.Label();
            this.BtnPocetak = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.BtnExit = new System.Windows.Forms.Button();
            this.panelPocetna = new System.Windows.Forms.Panel();
            this.pitanje11 = new SustavZaPreporukuMobitela.Pitanje1();
            this.pitanje21 = new SustavZaPreporukuMobitela.Pitanje2();
            this.pitanje31 = new SustavZaPreporukuMobitela.Pitanje3();
            this.pitanje41 = new SustavZaPreporukuMobitela.Pitanje4();
            this.panelPocetna.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(104, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(406, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Sustav za preporuku mobitela";
            // 
            // BtnPocetak
            // 
            this.BtnPocetak.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnPocetak.Location = new System.Drawing.Point(218, 113);
            this.BtnPocetak.Name = "BtnPocetak";
            this.BtnPocetak.Size = new System.Drawing.Size(144, 25);
            this.BtnPocetak.TabIndex = 1;
            this.BtnPocetak.Text = "Kreni";
            this.BtnPocetak.UseVisualStyleBackColor = true;
            this.BtnPocetak.Click += new System.EventHandler(this.BtnPocetak_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(149, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(289, 26);
            this.label2.TabIndex = 2;
            this.label2.Text = "Odgovorite na pitanja kako bi Vam preporučili mobilni uređaj\r\nkoji najviše odgova" +
    "ra Vašim potrebama.";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // BtnExit
            // 
            this.BtnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnExit.Location = new System.Drawing.Point(218, 144);
            this.BtnExit.Name = "BtnExit";
            this.BtnExit.Size = new System.Drawing.Size(144, 25);
            this.BtnExit.TabIndex = 3;
            this.BtnExit.Text = "Izlaz";
            this.BtnExit.UseVisualStyleBackColor = true;
            this.BtnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // panelPocetna
            // 
            this.panelPocetna.Controls.Add(this.label1);
            this.panelPocetna.Controls.Add(this.BtnExit);
            this.panelPocetna.Controls.Add(this.label2);
            this.panelPocetna.Controls.Add(this.BtnPocetak);
            this.panelPocetna.Location = new System.Drawing.Point(12, 76);
            this.panelPocetna.Name = "panelPocetna";
            this.panelPocetna.Size = new System.Drawing.Size(599, 310);
            this.panelPocetna.TabIndex = 4;
            // 
            // pitanje11
            // 
            this.pitanje11.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.pitanje11.Location = new System.Drawing.Point(0, 0);
            this.pitanje11.Name = "pitanje11";
            this.pitanje11.Size = new System.Drawing.Size(634, 461);
            this.pitanje11.TabIndex = 5;
            // 
            // pitanje21
            // 
            this.pitanje21.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.pitanje21.Location = new System.Drawing.Point(0, 0);
            this.pitanje21.Name = "pitanje21";
            this.pitanje21.Size = new System.Drawing.Size(634, 461);
            this.pitanje21.TabIndex = 6;
            // 
            // pitanje31
            // 
            this.pitanje31.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.pitanje31.Location = new System.Drawing.Point(0, 0);
            this.pitanje31.Name = "pitanje31";
            this.pitanje31.Size = new System.Drawing.Size(634, 461);
            this.pitanje31.TabIndex = 7;
            // 
            // pitanje41
            // 
            this.pitanje41.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.pitanje41.Location = new System.Drawing.Point(0, 0);
            this.pitanje41.Name = "pitanje41";
            this.pitanje41.Size = new System.Drawing.Size(634, 461);
            this.pitanje41.TabIndex = 8;
            // 
            // FormPocetna
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(634, 461);
            this.Controls.Add(this.pitanje41);
            this.Controls.Add(this.pitanje31);
            this.Controls.Add(this.pitanje21);
            this.Controls.Add(this.pitanje11);
            this.Controls.Add(this.panelPocetna);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormPocetna";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sustav za preporuku mobitela";
            this.panelPocetna.ResumeLayout(false);
            this.panelPocetna.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnPocetak;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BtnExit;
        private System.Windows.Forms.Panel panelPocetna;
        private Pitanje1 pitanje11;
        private Pitanje2 pitanje21;
        private Pitanje3 pitanje31;
        private Pitanje4 pitanje41;
    }
}


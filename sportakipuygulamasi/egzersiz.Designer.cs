namespace sportakipuygulamasi
{
    partial class egzersiz
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(egzersiz));
            this.pnl_onkol = new System.Windows.Forms.Panel();
            this.pnl_gogus = new System.Windows.Forms.Panel();
            this.pnl_sırt = new System.Windows.Forms.Panel();
            this.pnl_omuz = new System.Windows.Forms.Panel();
            this.pnl_bacak = new System.Windows.Forms.Panel();
            this.pnl_arkakol = new System.Windows.Forms.Panel();
            this.pnl_geri = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // pnl_onkol
            // 
            this.pnl_onkol.BackColor = System.Drawing.Color.Transparent;
            this.pnl_onkol.Location = new System.Drawing.Point(112, 153);
            this.pnl_onkol.Name = "pnl_onkol";
            this.pnl_onkol.Size = new System.Drawing.Size(143, 59);
            this.pnl_onkol.TabIndex = 0;
            this.pnl_onkol.Click += new System.EventHandler(this.pnl_onkol_Click);
            // 
            // pnl_gogus
            // 
            this.pnl_gogus.BackColor = System.Drawing.Color.Transparent;
            this.pnl_gogus.Location = new System.Drawing.Point(276, 153);
            this.pnl_gogus.Name = "pnl_gogus";
            this.pnl_gogus.Size = new System.Drawing.Size(122, 59);
            this.pnl_gogus.TabIndex = 1;
            this.pnl_gogus.Click += new System.EventHandler(this.pnl_gogus_Click);
            // 
            // pnl_sırt
            // 
            this.pnl_sırt.BackColor = System.Drawing.Color.Transparent;
            this.pnl_sırt.Location = new System.Drawing.Point(264, 232);
            this.pnl_sırt.Name = "pnl_sırt";
            this.pnl_sırt.Size = new System.Drawing.Size(105, 59);
            this.pnl_sırt.TabIndex = 2;
            this.pnl_sırt.Click += new System.EventHandler(this.pnl_sırt_Click);
            // 
            // pnl_omuz
            // 
            this.pnl_omuz.BackColor = System.Drawing.Color.Transparent;
            this.pnl_omuz.Location = new System.Drawing.Point(117, 312);
            this.pnl_omuz.Name = "pnl_omuz";
            this.pnl_omuz.Size = new System.Drawing.Size(105, 59);
            this.pnl_omuz.TabIndex = 3;
            this.pnl_omuz.Click += new System.EventHandler(this.pnl_omuz_Click);
            // 
            // pnl_bacak
            // 
            this.pnl_bacak.BackColor = System.Drawing.Color.Transparent;
            this.pnl_bacak.Location = new System.Drawing.Point(117, 232);
            this.pnl_bacak.Name = "pnl_bacak";
            this.pnl_bacak.Size = new System.Drawing.Size(124, 59);
            this.pnl_bacak.TabIndex = 4;
            this.pnl_bacak.Click += new System.EventHandler(this.pnl_bacak_Click);
            // 
            // pnl_arkakol
            // 
            this.pnl_arkakol.BackColor = System.Drawing.Color.Transparent;
            this.pnl_arkakol.Location = new System.Drawing.Point(246, 312);
            this.pnl_arkakol.Name = "pnl_arkakol";
            this.pnl_arkakol.Size = new System.Drawing.Size(182, 59);
            this.pnl_arkakol.TabIndex = 5;
            this.pnl_arkakol.Click += new System.EventHandler(this.pnl_arkakol_Click);
            // 
            // pnl_geri
            // 
            this.pnl_geri.BackColor = System.Drawing.Color.Transparent;
            this.pnl_geri.Location = new System.Drawing.Point(68, 432);
            this.pnl_geri.Name = "pnl_geri";
            this.pnl_geri.Size = new System.Drawing.Size(420, 47);
            this.pnl_geri.TabIndex = 7;
            this.pnl_geri.Click += new System.EventHandler(this.pnl_geri_Click);
            // 
            // egzersiz
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(555, 532);
            this.Controls.Add(this.pnl_geri);
            this.Controls.Add(this.pnl_arkakol);
            this.Controls.Add(this.pnl_bacak);
            this.Controls.Add(this.pnl_omuz);
            this.Controls.Add(this.pnl_sırt);
            this.Controls.Add(this.pnl_gogus);
            this.Controls.Add(this.pnl_onkol);
            this.Name = "egzersiz";
            this.Text = "Spor Takip Sistemi";
            this.Load += new System.EventHandler(this.egzersiz_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnl_onkol;
        private System.Windows.Forms.Panel pnl_gogus;
        private System.Windows.Forms.Panel pnl_sırt;
        private System.Windows.Forms.Panel pnl_omuz;
        private System.Windows.Forms.Panel pnl_bacak;
        private System.Windows.Forms.Panel pnl_arkakol;
        private System.Windows.Forms.Panel pnl_geri;
    }
}
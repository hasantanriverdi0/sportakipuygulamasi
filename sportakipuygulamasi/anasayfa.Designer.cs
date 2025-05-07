namespace sportakipuygulamasi
{
    partial class anasayfa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(anasayfa));
            this.label1 = new System.Windows.Forms.Label();
            this.pnl_egzersiz = new System.Windows.Forms.Panel();
            this.pnl_kayitlar = new System.Windows.Forms.Panel();
            this.pnl_profil = new System.Windows.Forms.Panel();
            this.pnl_antrenör = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(83, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            // 
            // pnl_egzersiz
            // 
            this.pnl_egzersiz.BackColor = System.Drawing.Color.Transparent;
            this.pnl_egzersiz.Location = new System.Drawing.Point(95, 125);
            this.pnl_egzersiz.Name = "pnl_egzersiz";
            this.pnl_egzersiz.Size = new System.Drawing.Size(158, 150);
            this.pnl_egzersiz.TabIndex = 1;
            this.pnl_egzersiz.Click += new System.EventHandler(this.pnl_egzersiz_Click);
            // 
            // pnl_kayitlar
            // 
            this.pnl_kayitlar.BackColor = System.Drawing.Color.Transparent;
            this.pnl_kayitlar.Location = new System.Drawing.Point(300, 125);
            this.pnl_kayitlar.Name = "pnl_kayitlar";
            this.pnl_kayitlar.Size = new System.Drawing.Size(158, 150);
            this.pnl_kayitlar.TabIndex = 2;
            this.pnl_kayitlar.Click += new System.EventHandler(this.pnl_kayitlar_Click);
            // 
            // pnl_profil
            // 
            this.pnl_profil.BackColor = System.Drawing.Color.Transparent;
            this.pnl_profil.Location = new System.Drawing.Point(95, 309);
            this.pnl_profil.Name = "pnl_profil";
            this.pnl_profil.Size = new System.Drawing.Size(158, 150);
            this.pnl_profil.TabIndex = 2;
            this.pnl_profil.Click += new System.EventHandler(this.pnl_profil_Click);
            // 
            // pnl_antrenör
            // 
            this.pnl_antrenör.BackColor = System.Drawing.Color.Transparent;
            this.pnl_antrenör.Location = new System.Drawing.Point(299, 308);
            this.pnl_antrenör.Name = "pnl_antrenör";
            this.pnl_antrenör.Size = new System.Drawing.Size(158, 150);
            this.pnl_antrenör.TabIndex = 2;
            this.pnl_antrenör.Click += new System.EventHandler(this.pnl_antrenör_Click);
            // 
            // anasayfa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(555, 532);
            this.Controls.Add(this.pnl_antrenör);
            this.Controls.Add(this.pnl_profil);
            this.Controls.Add(this.pnl_kayitlar);
            this.Controls.Add(this.pnl_egzersiz);
            this.Controls.Add(this.label1);
            this.Name = "anasayfa";
            this.Text = "Spor Takip Sistemi";
            this.Load += new System.EventHandler(this.anasayfa_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pnl_egzersiz;
        private System.Windows.Forms.Panel pnl_kayitlar;
        private System.Windows.Forms.Panel pnl_profil;
        private System.Windows.Forms.Panel pnl_antrenör;
    }
}
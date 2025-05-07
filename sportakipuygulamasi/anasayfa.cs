using System;
using System.Windows.Forms;

namespace sportakipuygulamasi
{
    public partial class anasayfa : Form
    {
        private string adSoyad;
        private kayit kayitFormu = new kayit(); // Tek instance
        public anasayfa(string adSoyad, string telefon)
        {
            InitializeComponent();
            this.adSoyad = adSoyad;
        }

        private void anasayfa_Load(object sender, EventArgs e)
        {
            label1.Text = $"Hoş geldin, {adSoyad}";
        }

        private void pnl_egzersiz_Click(object sender, EventArgs e)
        {
            egzersiz egzersizFormu = new egzersiz(kayitFormu);
            egzersizFormu.Show();
            this.Hide(); // Kaydı otomatik açma
        }

        private void pnl_kayitlar_Click(object sender, EventArgs e)
        {
            kayitFormu.Show(); // Aynı instance üzerinden göster
            this.Hide();
        }

        private void pnl_profil_Click(object sender, EventArgs e)
        {
            profil profil = new profil();
            profil.Show();
            this.Hide();
        }

        private void pnl_antrenör_Click(object sender, EventArgs e)
        {
            antrenör antrenör = new antrenör();
            antrenör.Show();
            this.Hide();
        }
    }
}

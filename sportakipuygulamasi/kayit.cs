using sagliktakipsistemi;
using System;
using System.Windows.Forms;

namespace sportakipuygulamasi
{
    public partial class kayit : Form
    {
        public kayit()
        {
            InitializeComponent();
        }
        string adSoyad, telefon = "";
        private void kayit_Load(object sender, EventArgs e)
        {
            label1.Text = Veri.EgzersizBilgisi;
        }

        private void panel1_Click(object sender, EventArgs e)
        {
            anasayfa anasayfa = new anasayfa(adSoyad, telefon);
            anasayfa.Show();
            this.Hide();

        }
    }
}

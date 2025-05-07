using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sportakipuygulamasi
{
    public partial class profil : Form
    {
        public string adSoyad, telefon;
        public profil()
        {
            InitializeComponent();
        }

        private void profil_Load(object sender, EventArgs e)
        {
            label1.Text = "Boy: " + Properties.Settings.Default.Boy + " cm";
            label2.Text = "Kilo: " + Properties.Settings.Default.Kilo + " kg";
            label3.Text = "Yaş: " + Properties.Settings.Default.Yas + " yıl";

            // VKİ hesapla
            double boy = Convert.ToDouble(Properties.Settings.Default.Boy) / 100;
            double kilo = Convert.ToDouble(Properties.Settings.Default.Kilo);
            double vki = kilo / (boy * boy);
            label4.Text = "VKİ: " + vki.ToString("0.00");
        }

        private void panel1_Click(object sender, EventArgs e)
        {
            guncelle guncelleForm = new guncelle();
            guncelleForm.Show();
            this.Hide();
        }

        private void panel2_DoubleClick(object sender, EventArgs e)
        {

        }

        private void panel2_Click(object sender, EventArgs e)
        {
            anasayfa anasayfa = new anasayfa(adSoyad, telefon);
            anasayfa.Show();
            this.Hide();
        }
    }
}

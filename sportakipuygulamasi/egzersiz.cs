using sagliktakipsistemi;
using System;
using System.Windows.Forms;

namespace sportakipuygulamasi
{
    public partial class egzersiz : Form
    {
        private kayit kayitFormu;
        public string adSoyad, telefon;
        public egzersiz(kayit gelenKayitFormu)
        {
            InitializeComponent();
            kayitFormu = gelenKayitFormu;
        }

        private void egzersiz_Load(object sender, EventArgs e)
        {

        }

        private void pnl_onkol_Click(object sender, EventArgs e)
        {
            Veri.EgzersizBilgisi = "Ön Kol Egzersizleri:\n \n" +
       "- Barbell Curl:\n Ayakta, düz barı kavrayarak kolları bük.\n \n" +
       "- Dumbbell Curl:\n Her elde bir dambıl ile kolları sırayla bük.\n \n" +
       "- Hammer Curl:\n Avuç içleri birbirine bakacak şekilde dambılları kaldır.\n \n" +
       "- Concentration Curl:\n Oturarak, dirseği dizine dayayıp dambılı kaldır.";
            MessageBox.Show("Egzersizleriniz kayıtlarım sayfasına gönderildi.");
        }

        private void pnl_gogus_Click(object sender, EventArgs e)
        {
            Veri.EgzersizBilgisi = "Göğüs Egzersizleri:\n" +
         "- Bench Press:\n Yatarak barı göğsüne indirip it.\n \n" +
         "- Incline Dumbbell Press:\n Yatık sehpadayken dambılları yukarı it.\n \n" +
         "- Chest Fly:\n Yatık pozisyonda dambılları açıp kapat.\n \n" +
         "- Push Up:\n Şınav pozisyonunda vücudu indirip kaldır.";
            MessageBox.Show("Egzersizleriniz kayıtlarım sayfasına gönderildi.");
        }

        private void pnl_bacak_Click(object sender, EventArgs e)
        {
            Veri.EgzersizBilgisi = "Bacak Egzersizleri:\n" +
        "- Squat:\n Ayakta çömelip kalk.\n \n" +
        "- Leg Press:\n Makinede ağırlığı bacaklarınla it.\n \n" +
        "- Lunges:\n Bir ayağınla öne adım atıp alçalarak kalk.\n \n" +
        "- Calf Raise:\n Ayak parmak uçlarına yüksel.";
            MessageBox.Show("Egzersizleriniz kayıtlarım sayfasına gönderildi.");
        }

        private void pnl_sırt_Click(object sender, EventArgs e)
        {
            Veri.EgzersizBilgisi = "Sırt Egzersizleri:\n" +
        "- Deadlift:\n Yerden ağırlığı belden güç alarak kaldır.\n \n" +
        "- Barbell Row:\n Bel önde, barı karına doğru çek.\n \n" +
        "- Pull Up:\n Barfiks çubuğuna asılıp kendini yukarı çek.\n \n" +
        "- Lat Pulldown:\n Makineden barı göğsüne doğru çek.";
            MessageBox.Show("Egzersizleriniz kayıtlarım sayfasına gönderildi.");
        }

        private void pnl_omuz_Click(object sender, EventArgs e)
        {
            Veri.EgzersizBilgisi = "Omuz Egzersizleri:\n \n" +
        "- Shoulder Press:\n Dambılları yukarı doğru it.\n \n" +
        "- Lateral Raise:\n Kolları yanlardan yukarı kaldır.\n \n" +
        "- Front Raise:\n Dambılları öne doğru kaldır.\n \n" +
        "- Shrug:\n Omuzları yukarı doğru silk.";
            MessageBox.Show("Egzersizleriniz kayıtlarım sayfasına gönderildi.");
        }

        private void pnl_arkakol_Click(object sender, EventArgs e)
        {
            Veri.EgzersizBilgisi = "Arka Kol Egzersizleri:\n" +
         "- Triceps Pushdown:\n Makineden ipi aşağı doğru çek.\n\n" +
         "- Skull Crusher:\n Yatarak ağırlığı alnına doğru indirip kaldır.\n\n" +
         "- Dips:\n Kollarla vücudu alçaltıp yükselt.\n\n" +
         "- Overhead Extension:\n Dambılı başının arkasından yukarı doğru kaldır.";
            MessageBox.Show("Egzersizleriniz kayıtlarım sayfasına gönderildi.");
        }

        private void pnl_geri_Click(object sender, EventArgs e)
        {
            anasayfa anasayfa = new anasayfa(adSoyad, telefon);
            anasayfa.Show();
            this.Hide();
        }
    }
}

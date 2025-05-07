using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sportakipuygulamasi
{
    public partial class giris : Form
    {
        public giris()
        {
            InitializeComponent();
        }

        private void panel1_Click(object sender, EventArgs e)
        {
            string adSoyad = textBox1.Text.Trim();
            string telefon = textBox2.Text.Trim();

            // Ad soyad kontrolü (En az 2 kelime, sadece harf)
            bool adSoyadGecerli = Regex.IsMatch(adSoyad, @"^[a-zA-ZÇçĞğİıÖöŞşÜü\s]{3,}$") && adSoyad.Split(' ').Length >= 2;

            // Telefon numarası kontrolü (10 haneli, sadece rakam, 0 ile başlamaz)
            bool telefonGecerli = Regex.IsMatch(telefon, @"^[1-9][0-9]{9}$");

            if (adSoyadGecerli && telefonGecerli)
            {
                anasayfa anaForm = new anasayfa(adSoyad, telefon);
                anaForm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Lütfen geçerli bir Ad Soyad (en az iki kelime) ve 10 haneli bir telefon numarası girin.", "Hatalı Giriş", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}

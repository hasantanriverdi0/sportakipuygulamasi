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
    public partial class antrenör : Form
    {
        string adSoyad, telefon;
        public antrenör()
        {
            InitializeComponent();
        }

        private void antrenör_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Click(object sender, EventArgs e)
        {
            string girilenMetin = richTextBox1.Text.Trim();

            if (string.IsNullOrWhiteSpace(girilenMetin))
            {
                MessageBox.Show("Lütfen bir metin giriniz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (girilenMetin.Length < 20)
            {
                MessageBox.Show("Lütfen en az 20 karakter giriniz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                MessageBox.Show("Talebiniz iletilmiştir. Desteğiniz için teşekkür ederiz.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                richTextBox1.Clear();
            }
        }

        private void panel2_Click(object sender, EventArgs e)
        {
            anasayfa anasayfa = new anasayfa(adSoyad, telefon);
            anasayfa.Show();
            this.Close();

        }
    }
}

using genel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace İZLEYİCİ1
{
    public partial class YÖNETİCİ : Form
    {
        
        public YÖNETİCİ()
        {
            InitializeComponent();
        }
        
        
        private void button1_Click(object sender, EventArgs e)
        {
           /* Yönetici yönetici= new Yönetici();
            yönetici.ad = txtt_ad.Text;
            yönetici.soyad= txtt_soyad.Text;
            yönetici.cinsiyet = txtt_cinsiyet.Text;
            yönetici.sifre= txtt_sifre.Text;
           */


            
            if (txtt_ad.Text == "ESRA" && txtt_sifre.Text == "esra123456" && txtt_soyad.Text=="ÖZNAZ" && txtt_yas.Text=="19" && txtt_cinsiyet.Text=="kız")
            {
                YÖNETİCİ_BİLGİ Form3 = new YÖNETİCİ_BİLGİ();
                Form3.Show();
            }

            else
            {
                MessageBox.Show("HATALI GİRİŞ");
            }
        }
        /*private void txtt_ad_TextChanged(object sender, EventArgs e)
        {
            txtt_ad.Text = yönetici.ad.ToString();
        }

        private void txtt_soyad_TextChanged(object sender, EventArgs e)
        {
            txtt_soyad.Text = yönetici.soyad.ToString();
        }

        private void txtt_yas_TextChanged(object sender, EventArgs e)
        {
            txtt_yas.Text = yönetici.yas.ToString();
        }

        private void txtt_cinsiyet_TextChanged(object sender, EventArgs e)
        {
            txtt_cinsiyet.Text = yönetici.cinsiyet.ToString();
        }
        
        private void txtt_sifre_TextChanged(object sender, EventArgs e)
        {
            txtt_sifre.Text = yönetici.sifre.ToString();
        }*/
    }
}

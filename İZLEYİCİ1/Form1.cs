using genel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace İZLEYİCİ1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        İzleyici izleyici=new İzleyici();
        public static string gonderilecekBilgi1;
        public static string gonderilecekBilgi2;
        public static string gonderilecekBilgi3;
        public static string gonderilecekBilgi4;
        //public static string gonderilecekBilgi5;
        
        private void button_sat_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                 izleyici.BiletAl(true);
                 string ekle_alOgr;
                 ekle_alOgr = txt_ad.Text + " " + txt_soyad.Text + " öğrenci " + txt_filmTur.Text + " türnden filmi 25 TL ye almıştır";
                gonderilecekBilgi1 = ekle_alOgr;
                YÖNETİCİ_BİLGİ f2 = new YÖNETİCİ_BİLGİ();

            }

            else
            {
                izleyici.BiletAl(false);
                string ekle_alTam;
                ekle_alTam = txt_ad.Text + " " + txt_soyad.Text + " yetişkin " + txt_filmTur.Text + " türnden filmi 50 TL ye almıştır";
                gonderilecekBilgi2 = ekle_alTam;
                YÖNETİCİ_BİLGİ f2 = new YÖNETİCİ_BİLGİ();
            }
                
            
                
        }

        private void button_iptal_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                izleyici.Biletİptal(true);
                string ekle_iptalOgr;
                ekle_iptalOgr = txt_ad.Text + " " + txt_soyad.Text + " öğrenci " + txt_filmTur.Text + " türnden filmi iptal etmiştir";
                gonderilecekBilgi3 = ekle_iptalOgr;
                YÖNETİCİ_BİLGİ f2 = new YÖNETİCİ_BİLGİ();
            }

            else
            {
                izleyici.Biletİptal(false);
                string ekle_iptalTam;
                ekle_iptalTam = txt_ad.Text + " " + txt_soyad.Text + " yetişkin " + txt_filmTur.Text + " türnden filmi iptal etmiştir";
                gonderilecekBilgi4 = ekle_iptalTam;
                YÖNETİCİ_BİLGİ f2 = new YÖNETİCİ_BİLGİ();
            }
                
        }

        private void button1_Click(object sender, EventArgs e)
        {
            

        }

        private void txt_ad_TextChanged(object sender, EventArgs e)
        {
           txt_ad.Text = izleyici.ad.ToString();
        }

        private void txt_soyad_TextChanged(object sender, EventArgs e)
        {
            txt_soyad.Text = izleyici.soyad.ToString();
        }

        private void txt_yas_TextChanged(object sender, EventArgs e)
        {
            txt_yas.Text = izleyici.yas.ToString();
        }

        private void txt_filmTur_TextChanged(object sender, EventArgs e)
        {
            txt_filmTur.Text = izleyici.filmTuru.ToString();
        }


        private void button1_Click_1(object sender, EventArgs e)
        {
            label6.Text = izleyici.BakiyeOgren().ToString();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {
            //gonderilecekBilgi5 = label6.Text;
            
        }
    }
}

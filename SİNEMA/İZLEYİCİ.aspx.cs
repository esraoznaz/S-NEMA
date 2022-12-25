using BİLGİ;
using genel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Web;
using System.Web.Services.Configuration;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SİNEMA
{
    public partial class İZLEYİCİ : System.Web.UI.Page

    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }
        static public List<BİLGİ.Korku> korku_list = new List<BİLGİ.Korku>();
        static public List<BİLGİ.Komedi> komedi_list = new List<BİLGİ.Komedi>();
        static public List<BİLGİ.Gerilim> gerilim_list = new List<BİLGİ.Gerilim>();
        static public List<BİLGİ.CizgiFilm> cizgiFilm_list = new List<BİLGİ.CizgiFilm>();

        static public List<double> korkuBakiye_list = new List<double>();
        static public List<double> komediBakiye_list = new List<double>();
        static public List<double> gerilimBakiye_list = new List<double>();
        static public List<double> cizgiFilmBakiye_list = new List<double>();

        readonly BİLGİ.Korku korku = new BİLGİ.Korku();       
        readonly BİLGİ.Komedi komedi = new BİLGİ.Komedi();
        readonly BİLGİ.Gerilim gerilim = new BİLGİ.Gerilim();
        readonly BİLGİ.CizgiFilm cizgiFilm = new BİLGİ.CizgiFilm();


        protected void Button_biletAl_Click(object sender, EventArgs e)
        { 
            if (drpDow_filmTur.SelectedValue == "1" )
            {
                korku.İsim = txt_isim.Text;
                korku.Soyisim = txt_soyisim.Text;
                korku.FilmYas = int.Parse(txt_yas.Text);
                korku.FilmAd = txt_filmAd.Text;
                
                object gelen = korku.KayitEkle(korku);
                korku_list.Add((BİLGİ.Korku)gelen);

                if (checkBox_ogr.Checked)
                {
                   
                    korku.BiletAl(true);
                }
                else
                {
                    
                    korku.BiletAl(false);
                }
                txt_korkuBakiye.Text = korku.BakiyeOgren().ToString();
                korkuBakiye_list.Add(double.Parse(txt_korkuBakiye.Text));
            }
            
            if (drpDow_filmTur.SelectedValue == "2")
            {
                komedi.İsim = txt_isim.Text;
                komedi.Soyisim= txt_soyisim.Text;
                komedi.FilmYas = int.Parse(txt_yas.Text);
                string text1 = txt_filmAd.Text;
                komedi.FilmAd = text1;
                object gelen = komedi.KayitEkle(komedi);
                komedi_list.Add((BİLGİ.Komedi)gelen);
                if (checkBox_ogr.Checked)
                {
                    komedi.BiletAl(true);
                }
                else
                {
                    komedi.BiletAl(false);
                }
                txt_komediBakiye.Text = komedi.BakiyeOgren().ToString();
                komediBakiye_list.Add(double.Parse(txt_komediBakiye.Text));
            }

            if (drpDow_filmTur.SelectedValue == "3" )
            {
                gerilim.İsim = txt_isim.Text;
                gerilim.Soyisim = txt_soyisim.Text;
                gerilim.FilmYas = int.Parse(txt_yas.Text);
                gerilim.FilmAd = txt_filmAd.Text;
                object gelen = gerilim.KayitEkle(gerilim);
                gerilim_list.Add((BİLGİ.Gerilim)gerilim);
                if (checkBox_ogr.Checked)
                {
                    gerilim.BiletAl(true);
                }
                else
                {
                    gerilim.BiletAl(false);
                }
                txt_gerilimBakiye.Text = gerilim.BakiyeOgren().ToString();
                gerilimBakiye_list.Add(double.Parse(txt_gerilimBakiye.Text));
            }
           
            if (drpDow_filmTur.SelectedValue == "4" )
            {
                cizgiFilm.İsim = txt_isim.Text;
                cizgiFilm.Soyisim = txt_soyisim.Text;
                cizgiFilm.FilmYas = int.Parse(txt_yas.Text);
                cizgiFilm.FilmAd = txt_filmAd.Text;
                object gelen = cizgiFilm.KayitEkle(cizgiFilm);
                cizgiFilm_list.Add((BİLGİ.CizgiFilm)cizgiFilm);
                if (checkBox_ogr.Checked)
                {
                    cizgiFilm.BiletAl(true);
                }
                else
                {
                    cizgiFilm.BiletAl(false);
                }
                txt_cizgiFilmBakiye.Text = cizgiFilm.BakiyeOgren().ToString();
                cizgiFilmBakiye_list.Add(double.Parse(txt_cizgiFilmBakiye.Text));
            }
        }
        protected void Button_biletİptal_Click(object sender, EventArgs e)
        {
            if (drpDow_filmTur.SelectedValue == "1" )
            {
                korku.İsim = txt_isim.Text;
                korku.Soyisim = txt_soyisim.Text;
                korku.FilmYas = int.Parse(txt_yas.Text);
                korku.FilmAd = txt_filmAd.Text;
                object gelen = korku.KayitEkle(korku);
                korku_list.Add((BİLGİ.Korku)gelen);
                if (checkBox_ogr.Checked)
                {
                    korku.Biletİptal(true);
                }
                else
                {
                    korku.Biletİptal(false);
                }
                txt_korkuBakiye.Text = korku.BakiyeOgren().ToString();
                korkuBakiye_list.Add(double.Parse(txt_korkuBakiye.Text));
            }

            if (drpDow_filmTur.SelectedValue == "2")
            {
                komedi.İsim = txt_isim.Text;
                komedi.Soyisim = txt_soyisim.Text;
                komedi.FilmYas = int.Parse(txt_yas.Text);
                komedi.FilmAd = txt_filmAd.Text;
                object gelen = komedi.KayitEkle(komedi);
                komedi_list.Add((BİLGİ.Komedi)gelen);
                if (checkBox_ogr.Checked)
                {
                    komedi.Biletİptal(true);
                }
                else
                {
                    komedi.Biletİptal(false);
                }
                txt_komediBakiye.Text =komedi.BakiyeOgren().ToString();
                komediBakiye_list.Add(double.Parse(txt_komediBakiye.Text));
            }

            if (drpDow_filmTur.SelectedValue == "3")
            {
                gerilim.İsim = txt_isim.Text;
                gerilim.Soyisim = txt_soyisim.Text;
                gerilim.FilmYas = int.Parse(txt_yas.Text);
                gerilim.FilmAd = txt_filmAd.Text;
                object gelen = gerilim.KayitEkle(gerilim);
                gerilim_list.Add((BİLGİ.Gerilim)gerilim);
                if (checkBox_ogr.Checked)
                {
                    gerilim.Biletİptal(true);
                }
                else
                {
                    gerilim.Biletİptal(false);
                }
                txt_gerilimBakiye.Text = gerilim.BakiyeOgren().ToString();
                gerilimBakiye_list.Add(double.Parse(txt_gerilimBakiye.Text));
            }

            if (drpDow_filmTur.SelectedValue == "4")
            {
                cizgiFilm.İsim = txt_isim.Text;
                cizgiFilm.Soyisim = txt_soyisim.Text;
                cizgiFilm.FilmYas = int.Parse(txt_yas.Text);
                cizgiFilm.FilmAd = txt_filmAd.Text;
                object genel = cizgiFilm.KayitEkle(cizgiFilm);
                cizgiFilm_list.Add((BİLGİ.CizgiFilm)cizgiFilm);
                if (checkBox_ogr.Checked)
                {
                    cizgiFilm.Biletİptal(true);
                }
                else
                {
                    cizgiFilm.Biletİptal(false);
                }
                txt_cizgiFilmBakiye.Text = cizgiFilm.BakiyeOgren().ToString();
                cizgiFilmBakiye_list.Add(double.Parse(txt_cizgiFilmBakiye.Text));
            }
        }
        protected void Button_bakiye_Click(object sender, EventArgs e)
        {
            double toplam = 0;
            for (int i = 0; i < korkuBakiye_list.Count; i++)
            {
                toplam += korkuBakiye_list[i];
            }
            txt_korkuBakiye.Text = toplam.ToString();

            double toplam1 = 0;
            for (int i = 0; i < komediBakiye_list.Count; i++)
            {
                toplam1 += komediBakiye_list[i];
            }
            txt_komediBakiye.Text = toplam1.ToString();

            double toplam2 = 0;
            for (int i = 0; i < gerilimBakiye_list.Count; i++)
            {
                toplam2 += gerilimBakiye_list[i];
            }
            txt_gerilimBakiye.Text = toplam2.ToString();

            double toplam3 = 0;
            for (int i = 0; i < cizgiFilmBakiye_list.Count; i++)
            {
                toplam3 += cizgiFilmBakiye_list[i];
            }
            txt_cizgiFilmBakiye.Text = toplam3.ToString();

            txt_toplamBakiye.Text = (toplam + toplam1 + toplam2 + toplam3).ToString();
        }
    }
}
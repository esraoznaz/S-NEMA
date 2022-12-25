using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BİLGİ
{
    public class CizgiFilm:Film
    {
        public override object KayitEkle(object kayıt)
        {
            BİLGİ.CizgiFilm cizgiFilm=(BİLGİ.CizgiFilm)kayıt;
            return cizgiFilm;
        }
        public double Bakiye_cizgiFilm { get; set; }
        public const double ogrBilet = 25;
        public const double tamBilet = 50;
        public void BiletAl(bool Durum)
        {
            if (Durum == true)
            {
                Bakiye_cizgiFilm+= ogrBilet;
            }
            else
            {
                Bakiye_cizgiFilm += tamBilet;
            }
        }
        public void Biletİptal(bool Durum)
        {
            if (Durum == true)
            {
                Bakiye_cizgiFilm -= ogrBilet;
            }
            else
            {
                Bakiye_cizgiFilm -= tamBilet;
            }
        }
        public  double BakiyeOgren()
        {
            return Bakiye_cizgiFilm;
        }
    }
}

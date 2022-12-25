using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BİLGİ
{
    public abstract class Film
    {
        public string FilmAd { get; set; }        
        public int FilmYas { get; set; }
        public string İsim { get; set; }
        public string Soyisim { get; set; }
        public abstract object KayitEkle(object kayıt);
        //public double Bakiye { get; set; }
        //public const int ogrBilet = 25;
        //public const int tamBilet = 50;
        //public abstract void BiletAl(bool durum);
        //public abstract void Biletİptal(bool durum);
        //public abstract double BakiyeOgren();
        
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BİLGİ
{
    public class Korku:Film
    {
        public override object KayitEkle(object kayıt)
        {
            BİLGİ.Korku korku = (BİLGİ.Korku)kayıt;
            return korku;
        }
        public double Bakiye_korku { get; set; }
        public const double ogrBilet = 25;
        public const double tamBilet = 50;

        public void BiletAl(bool Durum)
        {
            if (Durum == true)
            {
                Bakiye_korku += ogrBilet;
            }
            else
            {
                Bakiye_korku += tamBilet;
            }
        }
        public void Biletİptal(bool Durum)
        {
            if (Durum == true)
            {
                Bakiye_korku -= ogrBilet;
            }
            else
            {
                Bakiye_korku -= tamBilet;
            }
        }
        public double BakiyeOgren()
        {
            return Bakiye_korku;
        }



    }
}

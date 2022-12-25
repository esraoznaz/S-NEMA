using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BİLGİ
{
    public class Komedi:Film
    {
        public override object KayitEkle(object kayıt)
        {
            BİLGİ.Komedi komedi = (BİLGİ.Komedi)kayıt;
            return komedi;
        }
        public double Bakiye_komedi { get; set; }
        public const double ogrBilet = 25;
        public const double tamBilet = 50;
        public void BiletAl(bool Durum)
        {
            if (Durum == true)
            {
                Bakiye_komedi += ogrBilet;
            }
            else
            {
                Bakiye_komedi += tamBilet;
            }
        }
        public void Biletİptal(bool Durum)
        {
            if (Durum == true)
            {
                Bakiye_komedi -= ogrBilet;
            }
            else
            {
                Bakiye_komedi -= tamBilet;
            }
        }
        public double BakiyeOgren()
        {
            return Bakiye_komedi;
        }
    }
}

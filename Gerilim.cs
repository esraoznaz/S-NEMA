using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BİLGİ
{
    public class Gerilim:Film
    {
        public override object KayitEkle(object kayıt)
        {
            BİLGİ.Gerilim gerilim=(BİLGİ.Gerilim)kayıt;
            return gerilim;
        }
        public double Bakiye_gerilim { get; set; }
        public const double ogrBilet = 25;
        public const double tamBilet = 50;
        public void BiletAl(bool Durum)
        {
            if (Durum == true)
            {
                Bakiye_gerilim += ogrBilet;
            }
            else
            {
                Bakiye_gerilim += tamBilet;
            }
        }
        public void Biletİptal(bool Durum)
        {
            if (Durum == true)
            {
                Bakiye_gerilim -= ogrBilet;
            }
            else
            {
                Bakiye_gerilim -= tamBilet;
            }
        }
        public double BakiyeOgren()
        {
            return Bakiye_gerilim;
        }
    }
}

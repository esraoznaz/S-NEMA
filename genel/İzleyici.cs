using genel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace genel
{
    public class İzleyici : Ortak
    {
        public string ogrenci { get; set; }
        public string filmTuru { get; set; }
        public double Bakiye { get; set; }
        public int yas { get; set; }

        public const double ogrBiletFiyat = 25;
        public const double tamBiletFiyat = 50;
        
        public void BiletAl(bool Durum)
        {
            if (Durum == true)
            {
                Bakiye += ogrBiletFiyat;
            }
            else
            {
                Bakiye += tamBiletFiyat;
            }
        }
        public void Biletİptal(bool Durum)
        {
            if (Durum == true)
            {
                this.Bakiye -= ogrBiletFiyat;
            }
            else
            {
                this.Bakiye -= tamBiletFiyat;
            }
        }
        public double BakiyeOgren()
        {
            return Bakiye;
        }
    }
}

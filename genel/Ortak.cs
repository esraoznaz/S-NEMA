using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace genel
{
    public abstract class Ortak 
    {
        public string ad
        {
            get
            {
                return ad.ToUpper();
            }
            set
            {
                ad = value.Substring(0, 3);
            }
        }
        public string soyad
        {
            get
            {
                return soyad.ToUpper();
            }
            set
            {
                soyad = value.Substring(0, 3);
            }
        }
        
        public string cinsiyet { get; set; }
    }
    
}

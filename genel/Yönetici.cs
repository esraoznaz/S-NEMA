using genel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace genel
{
    public class Yönetici : Ortak
    {
        public string sifre
        {
            get
            {
                return sifre
                    ;
            }
            set
            {
                if (value.ToString().Length == 10)
                    sifre = value;
                else
                    Console.WriteLine("HATA! Şifreniz 10 Haneli Olmalıdır.");
            }
        }
    }
}

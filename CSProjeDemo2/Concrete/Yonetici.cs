using CSProjeDemo2.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSProjeDemo2.Concrete
{
    public class Yonetici : Personel
    {
        public string AdSoyad { get; set; }
        public int CalismaSaati { get; set; }

        private decimal _saatlikUcret;

        public Yonetici(string adSoyad, int calismaSaati, decimal saatlikUcret, decimal bonus)
        {
            AdSoyad = adSoyad;
            CalismaSaati = calismaSaati;
            _saatlikUcret = saatlikUcret;
            Bonus = bonus;
        }

        public decimal Bonus { get; set; }
        public decimal SaatlikUcret
        {
            get
            {
                return _saatlikUcret;
            }
            set
            {
                if (value < 500)
                    throw new Exception("Yöneticinin saatlik ücreti 500'den az olamaz.");

                _saatlikUcret = value;
            }
        }


        public override decimal MaasHesapla()
        {
            return (SaatlikUcret * CalismaSaati) + Bonus;
        }
    }
}

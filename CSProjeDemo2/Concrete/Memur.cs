using CSProjeDemo2.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSProjeDemo2.Concrete
{
    public class Memur : Personel
    {
        public string AdSoyad { get; set; }

        public decimal CalismaSaati { get; set; }
        public decimal Bonus { get; set; }

        private decimal _saatlikUcret;

        /// <summary>
        /// Memur sinifindan örnek alinirken derecesi belirtilmesi zorunlu degildir, belirtilmezse default olarak saatlik ücreti 500TL kabul edilir, ancak derece girilirse derecesine göre saatlik ücreti otomatik hesaplanir. Bkz. Memur.Derece
        /// </summary>
        /// <param name="adSoyad"></param>
        /// <param name="calismaSaati"></param>
        /// <param name="bonus"></param>
        public Memur(string adSoyad, decimal calismaSaati, decimal bonus)
        {
            AdSoyad = adSoyad;
            CalismaSaati = calismaSaati;
            Bonus = bonus;
        }

        public Derece Derecesi { get; set; }
        public decimal SaatlikUcret
        {
            get
            {
                return _saatlikUcret;
            }
            set
            {
                switch (Derecesi)
                {
                    case Derece.Derece1:
                        _saatlikUcret = 500;
                        break;
                    case Derece.Derece2:
                        _saatlikUcret = 550;
                        break;
                    case Derece.Derece3:
                        _saatlikUcret = 600;
                        break;
                    case Derece.Derece4:
                        _saatlikUcret = 650;
                        break;
                    case Derece.Derece5:
                        _saatlikUcret = 700;
                        break;
                    default:
                        _saatlikUcret = 500; //varsayilan olarak 500TL'dir.
                        break;
                }

            }
        }




        public override decimal MaasHesapla()
        {
            decimal normalMaas = (decimal)((SaatlikUcret * CalismaSaati) + Bonus);
            decimal ekMesaiMaas = 0;
            if (CalismaSaati > 180)
                ekMesaiMaas = (CalismaSaati - 180) * (SaatlikUcret * 1.5m);

            decimal toplamMaas = normalMaas + ekMesaiMaas;
            return toplamMaas;
        }


        /// <summary>
        /// Memur personellerin 1-5 derecelerine ve derecesine gore özlük haklarina  sahip oldugunu varsayalim
        /// </summary>
        public enum Derece
        {
            Derece1 = 1,
            Derece2,
            Derece3,
            Derece4,
            Derece5
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassOdev
{
    internal class Takım
    {
        public int PersonelSayisi { get; set; }
        public string Ad { get; set; }
        public string Soyad { get; set; }

        public string BirimAdı { get; set; }

        private int _yas;

        public int Yas
        {
            get { return _yas; }
            set { _yas = value; }
        }

        public void YasKontrol()
        {
            if (_yas >= 18)
            {
                Yas = _yas;
            }
            else
            {
                throw new Exception("18 Yaşından büyük olmak gerekmektedir." + (18-_yas) + " yas kaldı :)");
            }
        }

        public void PersonelSayıKontrol()
        {
            if (PersonelSayisi >= 10)
            {
                Console.WriteLine("Personel İhtiyacı Kalmadı ");
            }
            else
            {
                Console.WriteLine("Eksik Personel: " + (10-PersonelSayisi) + " adet");
            }
        }

        public void EkranaYaz()
        {
            Console.WriteLine("Ad: {0}, Soyad: {1}, Yaş: {2}, Birimi: {3}, Personel Sayısı: {4}", Ad, Soyad, Yas, BirimAdı, PersonelSayisi);
        }
    } 
}

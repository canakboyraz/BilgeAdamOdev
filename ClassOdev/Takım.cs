using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassOdev
{
    internal class Takım
    {
        public int NotSayisi { get; set; }
        public string Ad { get; set; }
        public string Soyad { get; set; }

        public string TakımAdı { get; set; }

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

        public void TakımNotKontrol()
        {
            if (NotSayisi >= 50)
            {
                Console.WriteLine("Tebrikler Başarılı!");
            }
            else
            {
                Console.WriteLine("Biraz gayret ! ");
            }
        }

        public void EkranaYaz()
        {
            Console.WriteLine("Ad: {0}, Soyad: {1}, Yaş: {2}, Takımı: {3}, Notu: {4}", Ad, Soyad, Yas, TakımAdı, NotSayisi);
        }

    }

    
}

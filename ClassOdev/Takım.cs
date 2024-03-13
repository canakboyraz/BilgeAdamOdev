using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassOdev
{
    internal class Takım
    {
        public int TakımSayisi { get; set; }
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public int Yas1 { get; set; }
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
                Yas1 = _yas;
            }
            else
            {
                throw new Exception("18 Yaşından büyük olmak gerekmektedir." + (18-_yas) + " yas kaldı dayan :)");
            }
        }

    }

    
}

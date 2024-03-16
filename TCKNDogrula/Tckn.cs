using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TCKNDogrula
{
    internal class Tckn
    {
        
        public bool KontrolTCNo(string tcNo) // Long , Hata kontrolü
        {
            int tekToplam = 0, ciftToplam = 0, kontrolOn,kontrolOnbir, toplamSon = 0;

            // TC numarası uzunluğunun 11 olması gerekiyor.

            if (tcNo.Length != 11) // yada 0 ile başlıyorsa
            {
                return false;
            }

            // TcNo'yu int olarak diziye atıyorum // int değilse de hata alır onun da kontrolünü yapmış oldum.

            int[] tcNoArray = new int[11];
            for (int i = 0; i < 11; i++)
            {
                tcNoArray[i] = int.Parse(tcNo[i].ToString());
            }

      
            // TC numarasının ilk hanesi sıfır olmamalıdır.
            if (tcNoArray[0] == '0')
            {
                return false;
            }
            
            //1. 3. 5. 7. ve 9. hanelerin toplamının 7 katından, 2. 4. 6. ve 8. hanelerin toplamı çıkartıldığında, elde edilen sonucun 10’a bölümünden kalan, yani Mod 10’u bize 10. haneyi verir.

            for (int i = 0; i < 9; i++) // 11. hane toplama işlemi burada yapılabilir.
            {
                if (i % 2 == 0)
                {
                    tekToplam = tekToplam + tcNoArray[i];
                }
                else
                {
                    ciftToplam = ciftToplam + tcNoArray[i];
                }
            }

            int toplamIlk = (tekToplam * 7) - ciftToplam;

            kontrolOn = toplamIlk % 10;

            if (kontrolOn != tcNoArray[9])
            {
                return false;
            }

            // 1. 2. 3. 4. 5. 6. 7. 8. 9. ve 10. hanelerin toplamından elde edilen sonucun 10’a bölümünden kalan, yani Mod10’u bize 11. haneyi verir.

            for (int i = 0; i < 10; i++)
            {
                toplamSon = toplamSon + tcNoArray[i];
            }
            kontrolOnbir = toplamSon % 10;

            if (kontrolOnbir != tcNoArray[10])

            {
                return false;
            }

            // Tüm kontroller geçildi, TC numarası doğru.
            return true;
        }

    }


}

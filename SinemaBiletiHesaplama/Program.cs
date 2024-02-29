/* Tam biletin fiyatı 80 TL, öğrenci biletinin fiyatı 60 TL olan bir sinema salonuna giden ailelerin
ödemesi gereken toplam ücreti bulan programı yazınız. 
(Bilet fiyatları sabit olarak girilecektir.)
(Programı yazarken test için 3 çocuklu(öğrenci) bir ailenin(anne - baba ve 3 çocuk) 41 TL çıkması gerekiyor)
*/

int ogrenci = 60;
int tam = 80;
int mısır = 100;
int bilet = 0;


Console.WriteLine("Tam bilet : " + tam + "  Öğrenci bilet : " + ogrenci + "  Mısır Menü : " + mısır);
Console.Write("Lütfen Tam bilet sayısı giriniz  ");
int sayi1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Lütfen Öğrenci bilet sayısı giriniz  ");
int sayi2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Lütfen Mısır menü adedinizi giriniz  ");
int sayi3 = Convert.ToInt32(Console.ReadLine());


if (sayi1 >= 0 && sayi2 >= 0 && sayi3 >= 0)
{
    bilet = (sayi2 * ogrenci) + (sayi1 * tam) + (sayi3 * mısır);
    Console.WriteLine("Ödemeniz Gereken Fiyat: " + bilet +" TL");
}
else
{
    Console.WriteLine("Hatalı giriş işlemi Tekrar deneyiniz.");
}

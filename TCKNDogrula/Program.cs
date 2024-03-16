// TCKN Doğrulama
/*
 * TC Kimlik numaraları 11 basamaktan oluşmaktadır. İlk 9 basamak arasında kurulan bir algoritma bize 10. basamağı, ilk 10 basamak arasında kurulan algoritma ise bize 11. basamağı verir.
* 11 hanelidir.
* Her hanesi rakamsal değer içerir.
* İlk hane 0 olamaz.
* 1. 3. 5. 7. ve 9. hanelerin toplamının 7 katından, 2. 4. 6. ve 8. hanelerin toplamı çıkartıldığında, elde edilen sonucun 10’a bölümünden kalan, yani Mod 10’u bize 10. haneyi verir.
* 1. 2. 3. 4. 5. 6. 7. 8. 9. ve 10. hanelerin toplamından elde edilen sonucun 10’a bölümünden kalan, yani Mod10’u bize 11. haneyi verir.
* 
*/


using TCKNDogrula;

Tckn nesne = new Tckn();

Console.WriteLine("TCKN Giriniz:");
string tckn = Console.ReadLine();

bool sonuc = nesne.KontrolTCNo(tckn);
if (sonuc)
{
    Console.WriteLine("TCKN DOĞRULANDI");
}
else
{
    Console.WriteLine("Hatalı !");
}
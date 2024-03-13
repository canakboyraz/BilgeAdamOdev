// Class Odev

using ClassOdev;

Console.WriteLine("Yas giriniz:");
int.TryParse(Console.ReadLine(), out int yasDegeri);

Takım takım = new Takım();

takım.TakımAdı = "Beşiktaş";
takım.TakımSayisi = 5;
takım.Yas = yasDegeri;

try
{
    takım.YasKontrol();
    Console.WriteLine("Yaşın uygun diğer bilgileri girmelisin:");
    Console.WriteLine("Ad: ");
    takım.Ad = Console.ReadLine();
    Console.WriteLine("SoyAd: ");
    takım.Soyad = Console.ReadLine();
    
    Console.WriteLine("Ad: {0}, Soyad: {1}, Yaş: {2}",takım.Ad,takım.Soyad,takım.Yas1);
}
catch (Exception e)
{
   Console.WriteLine("Hata "+e.Message);
}


//Console.WriteLine("Yas:" + takım.Yas);
//Console.WriteLine("Yas1:" + takım.Yas1);




// Class Odev

using ClassOdev;
Takım takım = new Takım();

Console.WriteLine("Yas giriniz:");
takım.Yas = Convert.ToInt32(Console.ReadLine());

takım.BirimAdı = "İnsan Kaynakları";

try
{
    takım.YasKontrol();
    Console.WriteLine("Yaşın uygun diğer bilgileri girmelisin:");

    Console.WriteLine("Ad: ");
    takım.Ad = Console.ReadLine();
    Console.WriteLine("Soyad: ");
    takım.Soyad = Console.ReadLine();

    Console.WriteLine("Personel Sayısı");
    takım.PersonelSayisi = Convert.ToInt32(Console.ReadLine());
    takım.PersonelSayıKontrol();

    takım.EkranaYaz();
}
catch (Exception e)
{
   Console.WriteLine("Hatalı işlem: "+e.Message);
}





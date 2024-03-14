// Class Odev

using ClassOdev;
Takım takım = new Takım();

Console.WriteLine("Yas giriniz:");
takım.Yas = Convert.ToInt32(Console.ReadLine());
takım.TakımAdı = "A Takımı";

try
{
    takım.YasKontrol();
    Console.WriteLine("Yaşın uygun diğer bilgileri girmelisin:");

    Console.WriteLine("Ad: ");
    takım.Ad = Console.ReadLine();
    Console.WriteLine("Soyad: ");
    takım.Soyad = Console.ReadLine();

    Console.WriteLine("Notun");
    takım.NotSayisi = Convert.ToInt32(Console.ReadLine());
    takım.TakımNotKontrol();

    takım.EkranaYaz();
}
catch (Exception e)
{
   Console.WriteLine("Hatalı işlem: "+e.Message);
}


//Console.WriteLine("Yas:" + takım.Yas);
//Console.WriteLine("Yas1:" + takım.Yas1);




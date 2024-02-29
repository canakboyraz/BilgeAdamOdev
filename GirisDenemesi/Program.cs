string kullaniciAdi = "admin";
string kullaniciAdi2 = "Admin";
string sifre = "12345";

Console.Write("Lütfen kullanıcı adını giriniz: ");
string ad = Console.ReadLine();

Console.Write("Lütfen şifre giriniz: ");
string pass = Console.ReadLine();

if (ad == kullaniciAdi || ad == kullaniciAdi2 && sifre == pass)
{
    Console.WriteLine("Giriş Başarılı");
}
else
{
    Console.WriteLine("Hatalı Deneme !");
}


// String Metot Örnek 3: Kullanıcı tarafından girilen ad ve şifre bilgilerinde, boşlukları temizleyen programı yazınız.


Console.WriteLine("Kullanıcı adınızı giriniz:");
string kullaniciAdi = Console.ReadLine();

Console.WriteLine("Şifrenizi giriniz:");
string sifre = Console.ReadLine();

kullaniciAdi = kullaniciAdi.Replace(" ", "");// ilk girilen değer değiştirilecek değer , ikincisi yerine konulacak değer
sifre = sifre.Replace(" ", "");

Console.WriteLine("Temizlenmiş kullanıcı adı: " + kullaniciAdi);
Console.WriteLine("Temizlenmiş şifre: " + sifre);





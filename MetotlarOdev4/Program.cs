/*
kullanıcı istediği kadar öğrencinin bilgisini girecek.
adı, soyadı, doğum tarihi, Cinsiyeti (E / K)
TCNo, kilosu (double) bilgilerini ayrı arraylerde tanımlayınız. 10 kişi tamamlanınca tüm bilgileri öğrenci bazında satır satır Ekrana yazınız.
Diziler sıfırdan başlayacak.
*/

string[] ad = new string[0];
string[] soyad = new string[0];
DateTime[] tarih = new DateTime[0];
Char[] cinsiyet = new Char[0];
long[] tckn = new long[0]; // long daha doğru
double[] kilo = new double[0];

int sayac = 0;

Console.WriteLine("Sırasıyla \n Ad \n Soyad \n Doğum Tarihi(örn 09.08.1993) \n Cinsiyet (E/K) \n TCKN() \n Kilo \n giriniz ");

while (true)
{
    if (sayac == 2)
    {
        break;
    }
    try
    {
        Array.Resize(ref ad, ad.Length + 1);
        ad[ad.Length - 1] = Console.ReadLine();

        Array.Resize(ref soyad, soyad.Length + 1);
        soyad[soyad.Length - 1] = Console.ReadLine();

        Array.Resize(ref tarih, tarih.Length + 1);
        tarih[tarih.Length - 1] = DateTime.Parse(Console.ReadLine());

        Array.Resize(ref cinsiyet, cinsiyet.Length + 1);
        cinsiyet[tarih.Length - 1] = Convert.ToChar(Console.ReadLine());

        Array.Resize(ref tckn, tckn.Length + 1);
        tckn[tckn.Length - 1] = Convert.ToInt64(Console.ReadLine());

        Array.Resize(ref kilo, kilo.Length + 1);
        kilo[kilo.Length - 1] = Convert.ToDouble(Console.ReadLine());

        // kontrol yönetimi

        sayac++;

    }
    catch (FormatException ex)
    {
        Console.WriteLine("Hatalı giriş yaptınız: " + ex.Message);
        continue;
    }
    catch (OverflowException ex)
    {
        Console.WriteLine("Girilen değer sınırların dışında: " + ex.Message);
        continue;
    }

}
Console.WriteLine("Yeni Dizi");
for (int i = 0; i < ad.Length; i++)
{
    Console.WriteLine(" Ad: " + ad[i]  + "\n Soyad: " + soyad[i] + "\n Doğum Tarihi: " + tarih[i] + "\n Cinsiyet " + cinsiyet[i] + "\n TCKN " + tckn[i] + "\n Kilo: " + kilo[i] +"\n" + new string('*',30));
}




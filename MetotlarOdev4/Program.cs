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
string[] tckn = new string[0];
double[] kilo = new double[0];

int sayac = 0;

Console.WriteLine("Sırasıyla Ad Soyad Doğum Tarihi(örn 09.08.1993) Cinsiyet (E/K) TCKN() Kilo giriniz ");

while (true)
{
    if (sayac == 1)
    {
        break;
    }
    string girisad = Console.ReadLine();
    string girisSoyad = Console.ReadLine();
    DateTime girisTarih = DateTime.Parse(Console.ReadLine());
    Char c = Convert.ToChar(Console.ReadLine());
    string girisTckn = Console.ReadLine();
    double girisKilo = Convert.ToDouble(Console.ReadLine());

    Array.Resize(ref ad, ad.Length + 1);
    Array.Resize(ref soyad, soyad.Length + 1);
    Array.Resize(ref tarih, tarih.Length + 1);
    Array.Resize(ref cinsiyet, cinsiyet.Length + 1);
    Array.Resize(ref tckn, tckn.Length + 1);
    Array.Resize(ref kilo, kilo.Length + 1);

    ad[ad.Length - 1] = girisad;
    soyad[soyad.Length - 1] = girisSoyad;
    tarih[tarih.Length - 1] = girisTarih;
    cinsiyet[tarih.Length - 1] = c;
    tckn[tckn.Length - 1] = girisTckn;
    kilo[kilo.Length - 1] = girisKilo;

    sayac++;
}
Console.WriteLine("Yeni Dizi");
for (int i = 0; i < ad.Length; i++)
{
    Console.WriteLine(" Ad: " + ad[i]  + "\n Soyad: " + soyad[i] + "\n Doğum Tarihi: " + tarih[i] + "\n Cinsiyet " + cinsiyet[i] + "\n TCKN " + tckn[i] + "\n Kilo: " + kilo[i]);
}




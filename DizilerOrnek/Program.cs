// 25 elemanlı bir integer dizisi tanımlayınız

int[] intDizi = new int[25];

// 5 elemanlı string dizisi tnaımlayıp değer atınız

string[] deger = new string[5] { "İstanbul", "Kocaeli", "Ankara", "Elazığ", "Antalya" };

// 4. elemanı değerinizi "Boost" olarak değiştiriniz

deger[3] = "Boost";

foreach (string degerYeni in deger)
{
    Console.WriteLine(degerYeni);
}

// Klavyeden kullanıcı tarafından girilen  sayıdan en büyüğünü bulan programı dizi kullanrak yazınız.

Console.WriteLine("Kaç sayı ?");
int adet = Convert.ToInt32(Console.ReadLine());

int[] sayilar = new int[adet];

for (int i = 0; i < adet; i++)
{
    Console.Write("{0}. sayıyı giriniz: ", i + 1);
    sayilar[i] = Convert.ToInt32(Console.ReadLine());
}

int enBuyuk = sayilar[0];
for (int i = 1; i < adet; i++)
{
    if (sayilar[i] > enBuyuk)
    {
        enBuyuk = sayilar[i];
    }
}

Console.WriteLine("En büyük sayı: {0}", enBuyuk);

// Bir array içindeki tüm sayıları çarpan bir döngü yazalım.

int[] dongu = new int[4] { 2, 3, 4, 5 };
int carpan = 1;

for (int i = 0; i < dongu.Length; i++)
{
    carpan = dongu[i] * carpan;
}

Console.WriteLine("Sonuc: " + carpan);

// 10 öğrenciden oluşan bir sınıfta öğrencilerin, programlamanın temelleri dersinden aldıkları notların toplamını ve ortalamasını bulan programı yazınız.

int ogrenciSayi = 10;
int[] notlar = new int[10];
int toplam = 0;

for (int i = 0; i < ogrenciSayi; i++)
{
    Console.Write(i + 1 + ". öğrencinin notunu giriniz: ");
    notlar[i] = Convert.ToInt32(Console.ReadLine());
}

foreach (int not in notlar)
{
    toplam = toplam + not;
}

double ortalama = (double)toplam / ogrenciSayi;

Console.WriteLine("Notların Toplamı: ", toplam);
Console.WriteLine("Notların Ortalaması:", ortalama);

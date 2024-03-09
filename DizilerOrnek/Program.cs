/*
// 25 elemanlı bir integer dizisi tanımlayınız

int[] intDizi = new int[25];

// 5 elemanlı string dizisi tanımlayıp değer atınız

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
    Console.Write(i+1 +". sayıyı giriniz: ");
    sayilar[i] = Convert.ToInt32(Console.ReadLine());
}

int enBuyuk = int.MinValue;

for (int i = 1; i < adet; i++)
{
    if (sayilar[i] > enBuyuk)
    {
        enBuyuk = sayilar[i];
    }
}

Console.WriteLine("En büyük sayı: ", enBuyuk);

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
int[] notlar = new int[10]; // ogrenciSayi değişkenini vererek sayı değiştiği takdirde sorun yaşamamızı engelleyebiliriz.
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

Console.WriteLine("Notların Toplamı: " + toplam);
Console.WriteLine("Notların Ortalaması:" + ortalama);
*/



// dizide bulunan 10 sayının küçükten büyüğe sıralamasını yapınız.
int[] dizi = new int[10];

for (int i = 0; i < dizi.Length; i++)
{
    Random rnd = new Random();
    dizi[i] = rnd.Next(1, 101); // Rastgele sayı atama
}

foreach (int sayi in dizi)
{
    Console.Write(sayi + " ");
}

Console.WriteLine();

int gecici;

for (int i = 0; i < dizi.Length; i++)
{
    for (int j = 0; j < dizi.Length; j++)
    {
        if (dizi[i] < dizi[j])
        {
            gecici = dizi[j];
            dizi[j] = dizi[i];
            dizi[i] = gecici;
        }
    }
}

Console.WriteLine("Yeni Dizi");

foreach (int sayi in dizi)
{
    Console.Write(sayi + " ");
}
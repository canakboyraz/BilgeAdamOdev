// KareAl ekrana yazdır metot

Console.Write("Sayı Giriniz:");
int sayi = Convert.ToInt32(Console.ReadLine()); // tryparce ile hata yönetimi

KareAl(sayi);

static void KareAl(int sayi)
{
    int sonuc = sayi * sayi;
    Console.WriteLine(sayi + ".nın Karesi: " + sonuc);
}

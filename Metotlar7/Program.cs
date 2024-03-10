// Metot Örnek 6: Kullanıcının girdiği iki sayıyı toplayan ve bu toplamın küpünü geriye döndüren metodu çağıran program..

Console.WriteLine("1. Sayıyı giriniz.");
int sayi1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("2. Sayıyı giriniz.");
int sayi2 = Convert.ToInt32(Console.ReadLine());


Islem(sayi1, sayi2);



static int Islem(int sayi1, int sayi2)
{
    int toplam = sayi1 + sayi2;
    int kup = toplam * toplam * toplam;
    return kup;
}
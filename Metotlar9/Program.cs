// Metot Örnek 8: Çarpma ve toplama işlemlerini iki ayrı metotta yapan, fakat çarpma metodunu, topla metodunda çağıran program


Console.WriteLine("1. Sayıyı giriniz.");
int sayi1 = Convert.ToInt32(Console.ReadLine());


Console.WriteLine("2. Sayıyı giriniz.");
int sayi2 = Convert.ToInt32(Console.ReadLine());


Topla(sayi1, sayi2);

static void Carp(int x, int y)
{
    int carp = x * y;
    Console.WriteLine("Carpım: " + carp);
}

static void Topla(int x, int y)
{
    Carp(x, y);
    int topla = x + y;
    Console.WriteLine("Toplam: " + topla);
}
Console.WriteLine("Lütfen 1. tam sayı giriniz");
int sayi1 = int.Parse(Console.ReadLine());

Console.WriteLine("Lütfen 2. tam sayı giriniz");
int sayi2 = int.Parse(Console.ReadLine());


Console.WriteLine("Lütfen işlem tipi seçim 1 - Toplama  2 - Çıkarma   3 - Bölme   4 - Çarpma");
int sayi3 = int.Parse(Console.ReadLine());

if (sayi3 == 1)
{
    Console.WriteLine("Toplam: " + (sayi1 + sayi2));
}
else if (sayi3 == 2)
{
    Console.WriteLine("Çıkarma: " + (sayi1 - sayi2));
}
else if (sayi3 == 3)
{
    Console.WriteLine("Bölme: " + (sayi1 / sayi2));
}
else if (sayi3 == 4)
{
    Console.WriteLine("Çarpma: " + (sayi1 * sayi2));
}
else
{
    Console.WriteLine("Hatalı işlem kodu girdiniz. Tekrar çalıştırınız.");
}
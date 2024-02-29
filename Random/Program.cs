Random rnd = new Random();
int sayi = rnd.Next(100);

int sayac = 0;
Console.WriteLine(sayi);

while (sayac <= 10)
{
    Console.WriteLine("Lütfen tahmin giriniz" + " Kalan Tahmin Hakkı: " + (10-sayac));
    int tahmin = int.Parse(Console.ReadLine());
    sayac = sayac + 1;

    if (tahmin < sayi)
    {
        Console.WriteLine("Yanlış! Daha büyük");
    }
    else if (tahmin > sayi)
    {
        Console.WriteLine("Yanlış ! Daha küçük");
    }
    else
    {
        Console.WriteLine("Tebrikler! Bildiniz. " + "Sayac: " + (sayac));
        break;
    }

}

Console.WriteLine("Tahmin Hakkınız bitti. Bulamadığın sayı: " + sayi);


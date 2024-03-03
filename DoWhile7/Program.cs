// Kullanıcı tarafından klavyeden girilen 10 adet sayının 3'e, 5'e ve her ikisinede tam bölünenlerinin sayısını ekrana yazan program

int sayi3 = 0;
int sayi5 = 0;
int sayiTum = 0;

Console.WriteLine("Lütfen 10 adet sayı girin:");

for (int i = 0; i < 10; i++)
{
    Console.WriteLine((i + 1) + " . sayıyı girin: ");

    int sayi = Convert.ToInt32(Console.ReadLine());

    if (sayi % 3 == 0 && sayi % 5 == 0)
    {
        sayiTum++;
    }
    else if (sayi % 3 == 0)
    {
        sayi3++;
    }
    else if (sayi % 5 == 0)
    {
        sayi5++;
    }
}

Console.WriteLine("3 e bölünenler: " + sayi3);
Console.WriteLine("5 e bölünenler: " + sayi5);
Console.WriteLine("Tamamına bölünenler: " + sayiTum);
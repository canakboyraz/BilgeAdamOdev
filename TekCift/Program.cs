// Girilen sayı tek ise iki katını çift ise yarsını ekrana yazdıran program.

// Klavyeden girilen bir sayının tek mi çift mi olduğunu bulup ekrana yazdıran program.

Console.Write("Lütfen sayı girin  ");
int sayi = Convert.ToInt32(Console.ReadLine());
int sonuc = 0;
if (sayi %2 == 0)
{
    sonuc = sayi / 2;
    Console.WriteLine("Girilen sayı çift " + sayi);
}
else
{
    sonuc = sayi * 2;
    Console.WriteLine("Girilen sayı tek " + sayi);
}
Console.WriteLine("Sonuc: " + sonuc);
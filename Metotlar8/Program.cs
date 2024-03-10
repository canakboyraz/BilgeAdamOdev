// Kullanıcıdan öğrenilen sayının tek mi çift mi olduğunu söyleyen bir metodu çağıran program..

Console.WriteLine("Sayıyı giriniz.");
int sayi = Convert.ToInt32(Console.ReadLine());

Islem(sayi);

static void Islem(int sayi)
{
    if (sayi %2 == 0)
    {
        Console.WriteLine("Girilen sayı çift");
    }
    else if (sayi == 0)
    {
        Console.WriteLine("0 Harici bir sayı giriniz");
    }
    else 
    {
        Console.WriteLine("Girilen sayı tek");
    }
}

// 1 den başlayan ve dışarıdan gönderilen değre kadar ekrana yazdırılan program

Console.WriteLine("sayı giriniz:");    
int sayi = Convert.ToInt32(Console.ReadLine());

Sayilar(sayi);

static void Sayilar(int sayi)
{
    for (int i = 1; i <= sayi; i++)
    {
        Console.Write(i + " ");
    }
}


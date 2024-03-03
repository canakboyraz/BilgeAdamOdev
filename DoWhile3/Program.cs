// While Örnek 8: Kullanıcının girdiği iki sayının çarpımı toplama operatörü kullanarak bulunan program.(Çarpma işlemi kullanılmayacak)

Console.WriteLine("Sayı 1 Giriniz.");
int sayi = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Sayı 2 Giriniz.");
int sayi2 = Convert.ToInt32(Console.ReadLine());

int toplam = 0;

while (sayi2 > 0)
{
    toplam = toplam + sayi;
    sayi2--;
}

Console.WriteLine("Sonuç: " + toplam);
// Continue Örnek: Kullanıcıdan kullanıcı sıfır girene kadar tamsayılar alınıyor. Kullanıcının girdiği sayı bir önceki sayıdan farklı olması isteniyor ve toplanıyor. Ekrana toplam yazılsın.(break, continue)


int toplam = 0;
int oncekiSayi = 0;

while (true)
{
    Console.Write("Bir sayı girin -- çıkış için 0 a basın");
    int sayi = Convert.ToInt32(Console.ReadLine());

    if (sayi == 0)
    {
        break;
    }

    if (sayi == oncekiSayi)
    {
        Console.WriteLine("Bir önceki sayıdan farklı bir sayı girin.");
        continue; 
    }

    toplam += sayi;
    oncekiSayi = sayi;
}

Console.WriteLine("Girilen farklı sayıların toplamı: " + toplam);
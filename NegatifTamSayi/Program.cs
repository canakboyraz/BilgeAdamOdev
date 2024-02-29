// Kullanıcıdan alınan iki tam sayıdan herhangi birisi negatif ise toplamlarını, ikisi de negatif ise çarpımlarını, ikisi de pozitif ise aritmetik ortalamalarını bulup ekrana yazan program...
// (Sıfır girilirse, hangi sayı 0 girildiyse o sayiyi tekrar alsın)

devam1:
Console.Write("Lütfen 1. sayı girin  ");
int sayi1 = Convert.ToInt32(Console.ReadLine());
if (sayi1 == 0)
{
    Console.WriteLine("0 Hariç tekrar giriniz.");
    goto devam1;
}

devam2:
Console.Write("Lütfen 2. sayı girin  ");
int sayi2 = Convert.ToInt32(Console.ReadLine());
if (sayi2 == 0)
{
    Console.WriteLine("0 Hariç tekrar giriniz.");
    goto devam2;
}

int toplam = 0;

if (sayi1 <= 0 && sayi2 >= 0)
{
    toplam = sayi1 + sayi2;
}
else if (sayi1 >= 0 && sayi2 <= 0)
{
    toplam = sayi1 + sayi2;
}
else if (sayi1 <= 0 && sayi2 <= 0)
{
    toplam = sayi1 * sayi2;
}
else
{
    toplam = ( sayi1 + sayi2) / 2;
}

Console.WriteLine("Sonuç: " + toplam);

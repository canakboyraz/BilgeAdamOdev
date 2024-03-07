// Kullanıcıdan alınan 0 ile 1 arasındaki sayının %'lik oranını ekrana gösteren program

Console.WriteLine("0 ila 1 arasında bir sayı giriniz.");
double sayi = Convert.ToDouble(Console.ReadLine());

if (sayi > 0 && sayi < 1)
{
    double yuzde = sayi * 100;
    Console.WriteLine("Yuzdemiz: %"+yuzde);
}
else
{
    Console.WriteLine("0 ila 1 arasında sayı giriniz");
}
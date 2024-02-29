Console.WriteLine("Lütfen 3 basamaklı sayı giriniz");
int sayi1 = int.Parse(Console.ReadLine());

if (sayi1 >= 100 && sayi1 <= 999)
{
    int yuzler = sayi1 / 100;
    int x = sayi1 - (yuzler * 100);
    int onlar = x / 10;
    int birler = x - (onlar * 10);

    Console.WriteLine("Yüzler: " +  yuzler + " Onlar: " + onlar + " Birler: " + birler);
}
else
{
    Console.WriteLine("3 basamaklı sayı giriniz.");
}

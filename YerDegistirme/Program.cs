Console.WriteLine("Lütfen 1. tam sayı giriniz");
int sayi1 = int.Parse(Console.ReadLine());

Console.WriteLine("Lütfen 2. tam sayı giriniz");
int sayi2 = int.Parse(Console.ReadLine());

Console.WriteLine("Sayi 1: " + sayi1 + "  Sayi 2: " + sayi2);

sayi1 = sayi1 + sayi2;
sayi2 = sayi1 - sayi2;
sayi1 = sayi1 - sayi2;


Console.WriteLine("Sayi 1: " + sayi1 + "  Sayi 2: " + sayi2);


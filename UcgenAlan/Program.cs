// Klavyeden kullanıcı tarafından dik kenarları girilen bir üçgenin alanını hesaplayan program.

Console.Write("Lütfen 1. Kenarı girin  ");
double sayi1 = Convert.ToDouble(Console.ReadLine());

Console.Write("Lütfen 2. Kenarı girin  ");
double sayi2 = Convert.ToDouble(Console.ReadLine());

double alan = (sayi1 * sayi2) / 2;

Console.WriteLine("Üçgen Alanı: " + alan);
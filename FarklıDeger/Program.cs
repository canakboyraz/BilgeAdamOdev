Console.WriteLine("Lütfen Double sayı giriniz: ");
double sayiD = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Lütfen Int sayı giriniz: ");
int sayiI = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Lütfen Decimal sayı giriniz: ");
decimal sayiL = Convert.ToDecimal(Console.ReadLine());

int sonuc = sayiI + (int)sayiD + (int)sayiL;

Console.WriteLine("Sonuc: " + sonuc);



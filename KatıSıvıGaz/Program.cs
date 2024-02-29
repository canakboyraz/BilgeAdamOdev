Console.WriteLine("Lütfen suyun sıcaklığını giriniz");
int sayi = int.Parse(Console.ReadLine());

if (sayi >= 100)
{
    Console.WriteLine("Gaz haldedir.");
}
else if (sayi <= 0)
{
    Console.WriteLine("Katı haldedir.");
}
else
{
    Console.WriteLine("Sıvı Haldedir.");
}

Console.Read();
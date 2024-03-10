// Çarpma ve toplama ayrı metot

using System.Reflection.Metadata.Ecma335;

Console.WriteLine("1. sayıyı giriniz");
int sayi1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("2. sayıyı giriniz");
int sayi2 = Convert.ToInt32(Console.ReadLine());

Carp(sayi1, sayi2);
Bolme(sayi1, sayi2);

static void Carp(int x, int y)
{
    int carp = x * y;
    Console.WriteLine("Carpım: " + carp);
}

static void Bolme(int x, int y)
{
    int bolme = x / y;
    Console.WriteLine("Bolme: " + bolme);
}

// Kullanıcıdan alınan nota göre harf notu veren program

Console.Write("Lütfen Notu girin ");
double sayi = Convert.ToDouble(Console.ReadLine());

double sonuc = sayi;  

if (sonuc >= 90)
{
    Console.WriteLine("Tebrikler Geçme notunuz A");
}
else if (sonuc >= 80  || sonuc < 90)
{
    Console.WriteLine("Tebrikler Geçme notunuz B");
}
else if (sonuc >= 70 || sonuc <= 80)
{
    Console.WriteLine("Tebrikler Geçme notunuz C");
}
else if (sonuc >= 60 || sonuc <= 70)
{
    Console.WriteLine("Tebrikler Geçme notunuz D");
}
else
{
    Console.WriteLine("Dersi geçmek için yeterli değil.");
}


Console.WriteLine("Adınızı giriniz: ");
string ad = Console.ReadLine();

Kullanici(ad);

static void Kullanici(string ad)
{
    if (ad == null || ad.Equals(" "))
    {
        Console.WriteLine("Merhaba Dostum");
    }
    else
    {
        Console.WriteLine("Merhaba " + ad);
    }
}




// Bir string ifade  içerisinde kullanıcının girmiş olduğu karakteri arayan programı yazınız.


Console.WriteLine("Bir metin giriniz:");
string metin = Console.ReadLine();

Console.WriteLine("Aranacak karakteri giriniz:");
char harf = Console.ReadKey().KeyChar; // Kullanıcının girdiği harfi al

int sayac = 0;

foreach (char karakter in metin)
{
    if (karakter == harf)
    {
        sayac++;
    }
}

if (sayac > 0)
{
    Console.WriteLine($"\n'{harf}' karakteri {metin} ifadesinde {sayac} kez bulunmaktadır.");
}
else
{
    Console.WriteLine($"\n'{harf}' karakteri {metin} ifadesinde bulunmamaktadır.");
}
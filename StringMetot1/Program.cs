//String Metot Örnek 1: Kullanıcının girmiş olduğu cümlede "hava" kelimesini arayan programı yazınız.

Console.WriteLine("Metin:");
string metin = Console.ReadLine();

if (metin.Contains("hava")) // değer arama 
{
    Console.WriteLine("İçinde hava geçmektedir.");
}
else
{
    Console.WriteLine("İçinde hava kelimesi yoktur !");
}
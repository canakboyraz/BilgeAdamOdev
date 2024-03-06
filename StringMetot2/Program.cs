// String Metot Örnek 2: Kullanıcının girmiş olduğu iki metinsel  ifadeyi karşılaştıran ve eşleşme durumunu gösteren programı yazınız.

Console.WriteLine("Birinci metin");
string metin1 = Console.ReadLine();

Console.WriteLine("İkinci metin");
string metin2 = Console.ReadLine();

if (metin1.Equals(metin2)) // string de Equals
{
    Console.WriteLine("Girilen metinler eşit.");
}
else
{
    Console.WriteLine("Girilen metinler birbirine eşit değildir.");
}
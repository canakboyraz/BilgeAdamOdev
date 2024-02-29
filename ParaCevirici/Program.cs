//Klavyeden kullanıcı tarafından paraMiktari cinsinden para miktarını, yine kullanıcı tarafından girilen Euro ve Dolar kuruna göre paraMiktari'nin kaç Euro ve kaç Dolar olduğunu bulan programı yazınız.,

Console.WriteLine("Lütfen TL para miktarını giriniz: ");
double paraMiktari = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Euro için 'e' - Dolar için 'd' basınız");
string birim = Console.ReadLine();

double sonuc = 0;

if (birim == "e")
{
    Console.WriteLine("Lütfen Euro kurunu giriniz. ");
    double euroKur = Convert.ToDouble(Console.ReadLine());
    sonuc = paraMiktari / euroKur;
    Console.WriteLine("Euro: " + sonuc);
}
else if (birim == "d")
{
    Console.WriteLine("Lütfen Dolar kurunu giriniz. ");
    double dolarKur = Convert.ToDouble(Console.ReadLine());
    sonuc = paraMiktari / dolarKur;
    Console.WriteLine("Dolar: " + sonuc);
}


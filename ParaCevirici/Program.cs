//Klavyeden kullanıcı tarafından paraMiktari cinsinden para miktarını, yine kullanıcı tarafından girilen Euro ve Dolar kuruna göre paraMiktari'nin kaç Euro ve kaç Dolar olduğunu bulan programı yazınız.,


/*
 
Console.WriteLine("Lütfen TL para miktarını giriniz: ");
double paraMiktari = Convert.ToDouble(Console.ReadLine());

tekrar:
Console.WriteLine("Euro için 'e' - Dolar için 'd' basınız");
string birim = Console.ReadLine();

double sonuc = 0;

if (birim == "e" || birim =="E")
{
    Console.WriteLine("Lütfen Euro kurunu giriniz. ");
    double euroKur = Convert.ToDouble(Console.ReadLine());
    sonuc = paraMiktari / euroKur;
    Console.WriteLine("Euro: " + sonuc);
}
else if (birim == "d" || birim =="D")
{
    Console.WriteLine("Lütfen Dolar kurunu giriniz. ");
    double dolarKur = Convert.ToDouble(Console.ReadLine());
    sonuc = paraMiktari / dolarKur;
    Console.WriteLine("Dolar: " + sonuc);
}
else
{
    Console.WriteLine("Hatalı giriş. Tekrar deneyin");
    goto tekrar;
}

*/

try
{
    Console.WriteLine("Lütfen TL para miktarını giriniz: ");
    double paraMiktari = Convert.ToDouble(Console.ReadLine());

    tekrar:
    Console.WriteLine("Euro için 'e' - Dolar için 'd' basınız");
    string birim = Console.ReadLine();

    double sonuc = 0;

    if (birim == "e" || birim == "E")
    {
        try
        {
            Console.WriteLine("Lütfen Euro kurunu giriniz. ");
            double euroKur = Convert.ToDouble(Console.ReadLine());
            sonuc = paraMiktari / euroKur;
            Console.WriteLine("Euro: " + sonuc);
        }
        catch (FormatException)
        {
            Console.WriteLine("Geçersiz Euro değeri girdiniz.");
            goto tekrar;
        }
        catch (DivideByZeroException)
        {
            Console.WriteLine("Euro değeri sıfır olamaz.");
            goto tekrar;
        }
    }
    else if (birim == "d" || birim == "D")
    {
        try
        {
            Console.WriteLine("Lütfen Dolar kurunu giriniz. ");
            double dolarKur = Convert.ToDouble(Console.ReadLine());
            sonuc = paraMiktari / dolarKur;
            Console.WriteLine("Dolar: " + sonuc);
        }
        catch (FormatException)
        {
            Console.WriteLine("Geçersiz Dolar değeri girdiniz.");
            goto tekrar;
        }
        catch (DivideByZeroException)
        {
            Console.WriteLine("Dolar değeri sıfır olamaz.");
            goto tekrar;
        }
    }
    else
    {
        Console.WriteLine("Hatalı giriş. Tekrar deneyin");
        goto tekrar;
    }
}
catch (FormatException)
{
    Console.WriteLine("Geçersiz para miktarı girdiniz.");
}

// String Metot Örnek 9:Kullanıcı tarafından girilen sayıyı "para birimi" değeri olarak ekranda gösteren porgramı yazınız.
// Format() Metodu:
Console.WriteLine("Lütfen bir sayı giriniz:");
double sayi = Convert.ToDouble(Console.ReadLine());


Console.WriteLine("para birimini seçimi: \n 1 - Türk Lira (TL) \n 2 - Dolar (USD) \n 3 - Euro (EUR)");

int secim = Convert.ToInt32(Console.ReadLine());

if (secim < 1 || secim > 3)
{
    Console.WriteLine("Geçersiz seçim! Lütfen 1 ile 3 arasında bir seçim yapınız.");
    return;
}

double sonuc = 0;
string birim = "";

switch (secim)
{
    case 1:
        sonuc = sayi * 10; // 1 birim = 1 TL
        birim = "Türk Lirası (TL)";
        break;
    case 2:
        sonuc = sayi * 0.031; // 1 birim = 0.031 USD
        birim = "Amerikan Doları (USD)";
        break;
    case 3:
        sonuc = sayi * 0.029; // 1 birim = 0.029 EUR
        birim = "Euro (EUR)";
        break;
    default:
        Console.WriteLine("Beklenmeyen bir hata oluştu.");
        return;
}

Console.WriteLine($"{sayi} birim, {sonuc} {birim} değerine eşittir.");
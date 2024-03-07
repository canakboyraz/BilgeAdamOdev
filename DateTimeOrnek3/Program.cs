//// ÖRnek 4: Girilen iki tarih arasındaki gün farkını  bulan programı yazınız. 
//// Timespan kullanın,
///
Console.WriteLine("İlk tarihi girin (gg.aa.yyyy):");
if (!DateTime.TryParse(Console.ReadLine(), out DateTime ilkTarih))
{
    Console.WriteLine("Geçersiz tarih formatı! Lütfen gg.aa.yyyy formatında bir tarih girin.");
    return;
}

Console.WriteLine("İkinci tarihi girin (gg.aa.yyyy):");
if (!DateTime.TryParse(Console.ReadLine(), out DateTime ikinciTarih))
{
    Console.WriteLine("Geçersiz tarih formatı! Lütfen gg.aa.yyyy formatında bir tarih girin.");
    return;
}

TimeSpan fark = ilkTarih - ikinciTarih;// tarihler arası fark hesaplanır
int gunFarki = Math.Abs(fark.Days); // gün farkı alınır. ( Days )

Console.WriteLine($"İki tarih arasındaki gün farkı: {gunFarki}");
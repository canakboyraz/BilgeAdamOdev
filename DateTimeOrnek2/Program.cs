// ÖRnek 3: Kullanıcıdan alınan doğum tarihi bilgisi ile kullanıcının yaşını hesaplayan program

Console.WriteLine("Doğum tarihinizi girin (gg.aa.yyyy):");
if (!DateTime.TryParse(Console.ReadLine(), out DateTime dogumTarihi))
{
    Console.WriteLine("Geçersiz tarih formatı! Lütfen gg.aa.yyyy formatında bir tarih girin.");
    return;
}

TimeSpan yasZamani = DateTime.Now - dogumTarihi;
int yas = (int)(yasZamani.Days / 365); 

Console.WriteLine("Yaşınız: " + yas);

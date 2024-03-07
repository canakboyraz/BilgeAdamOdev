//Örnek 3:  Kullanıcı tarafından girilen tüm ondalıklı sayıları aşağı yuvarlayan programı yazınız.


Console.WriteLine("Ondalıklı sayıları girmeye başlayın (çıkmak için 'e' yazın):");

while (true)
{
    Console.Write("Sayı: ");
    string input = Console.ReadLine();

    if (input.ToLower() == "e")
    {
        Console.WriteLine("Çıkış");
        break;
    }

    if (!double.TryParse(input, out double sayi))
    {
        Console.WriteLine("Geçersiz giriş! Lütfen bir sayı giriniz.");
        continue; 
    }

    double ySayi = Math.Floor(sayi);  // Yukarı içinde Math.Ceiling() kullanılıyor.
    Console.WriteLine("Yuvarlanmıs sayı " + ySayi);
}
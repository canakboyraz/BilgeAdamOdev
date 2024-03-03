// Break Örnek: Kullanıcı 'q' veya 'Q' karakterini girildiği anda döngüden break keywordü ile çıkınız.

while (true)
{
    Console.Write("Harf Girin");
    string deger = Console.ReadLine();

    // Girilen karakter q veya Q ise döngüyü kır
    if (deger == "q" || deger == "Q")
    {
        Console.WriteLine("Doğru Harf");
        break;
    }

    Console.WriteLine("Girilen : " + deger);
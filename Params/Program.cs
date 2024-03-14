// Kullanıcıdan belirsiz sayıda kelime alın ve params olarak metoda gönderin Kullanıcıdan aldığı kelimeleri kullanıcıdan aldığı karakter ile birlşetir.
string[] kelime = new string[0];




while (true)
{
    Console.WriteLine("Çıkmak için 1 - Devam etmek için 2 basınız");
    int secim = Convert.ToInt32(Console.ReadLine());

    if (secim == 1)
    {
        break;
    }

    try
    {
        Console.WriteLine("Kelime giriniz");
        Array.Resize(ref kelime, kelime.Length + 1);
        kelime[kelime.Length - 1] = Console.ReadLine();
    }
    catch (FormatException ex)
    {
        Console.WriteLine("Hatalı giriş yaptınız: " + ex.Message);
        continue;
    }
    catch (OverflowException ex)
    {
        Console.WriteLine("Girilen değer sınırların dışında: " + ex.Message);
        continue;
    }
}

Console.WriteLine("Karakter giriniz.");
char karakter = Convert.ToChar(Console.ReadLine());

Console.WriteLine("Yeni Cümle");
for (int i = 0; i < kelime.Length; i++)
{
    Console.Write(kelime[i] + karakter);
}
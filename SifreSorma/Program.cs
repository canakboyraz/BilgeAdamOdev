
// Klavyeden sıfır girilinceye kadar girilen sayıların kendisini ve karesini ekrana yazdıran program

// While Örnek 8: Kullanıcının girdiği iki sayının çarpımı toplama operatörü kullanarak bulunan program.(Çarpma işlemi kullanılmayacak)

// Kullanıcı tarafından klavyeden girilen 10 adet sayının 3'e, 5'e ve her ikisinede tam bölünenlerinin sayısını ekrana yazan program

// Do-While Örnek 1: Kullanıcı sifreyi "123" olarak girene kadar şifreyi soran program


// Do-While Örnek 2: Kullanıcı tarafından girilen 10 sayıdan kaç tanesinin 3 basamaklı olduğunu bulan program.

// Break Örnek: Kullanıcı 'q' veya 'Q' karakterini girildiği anda döngüden break keywordü ile çıkınız.

// Continue Örnek: Kullanıcıdan kullanıcı sıfır girene kadar tamsayılar alınıyor. Kullanıcının girdiği sayı bir önceki sayıdan farklı olması isteniyor ve toplanıyor. Ekrana toplam yazılsın.(break, continue)

//[16:29] Zafer Dorter (BilgeAdam Boost)
// While Örnek 8: Kullanıcının girdiği iki sayının çarpımı toplama operatörü kullanarak bulunan program.(Çarpma işlemi kullanılmayacak)

// Kullanıcı tarafından klavyeden girilen 10 adet sayının 3'e, 5'e ve her ikisinede tam bölünenlerinin sayısını ekrana yazan program

// Do-While Örnek 1: Kullanıcı sifreyi "123" olarak girene kadar şifreyi soran program

// Do-While Örnek 2: Kullanıcı tarafından girilen 10 sayıdan kaç tanesinin 3 basamaklı olduğunu bulan program.

// Break Örnek: Kullanıcı 'q' veya 'Q' karakterini girildiği anda döngüden break keywordü ile çıkınız.

// Continue Örnek: Kullanıcıdan kullanıcı sıfır girene kadar tamsayılar alınıyor. Kullanıcının girdiği sayı bir önceki sayıdan farklı olması isteniyor ve toplanıyor. Ekrana toplam yazılsın.(break, continue)

string sifre = "123";
string deger;

do
{
    Console.WriteLine("Şifreyi girin: ");
    deger = Console.ReadLine();

    if (deger != sifre)
    {
        Console.WriteLine("Hatalı şifre. Tekrar deneyin.");
    }

} while (deger != sifre);

Console.WriteLine("Doğru ");


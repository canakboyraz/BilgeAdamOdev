// See Girilen bir kelimeyi büyük harf ve küçük harf şeklinde ayrı ayrı ekrana yazdıran program

Console.Write("Bir kelime girin: ");
string kelime = Console.ReadLine();

string kKelime = kelime.ToLower();
Console.WriteLine("Küçük " + kKelime);

// Büyük harf dönüşümü
string bKelime = kelime.ToUpper();
Console.WriteLine("Büyük " + bKelime);

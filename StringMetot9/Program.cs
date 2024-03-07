// Kullanıcı tarafından girilen bir cümle içerisinde bulunan bir kelimeyi, yerine yeni bir kelime ile değiştiren programı yazınız

Console.WriteLine("Bir cümle yazın");
string cumle = Console.ReadLine();

Console.WriteLine("Değişmesini istediğimiz kelime yaz");
string eKelime = Console.ReadLine();

string yKelime = "yeni";

string yCumle = cumle.Replace(eKelime, yKelime);

Console.WriteLine("Yeni Cümle:" + yCumle);

//Replace -- yer değiştirmeye yarıyor eski ilke yeni ikinciye yazılıyor.

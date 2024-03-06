// See Girilen kredi kartı numarasının sadece son 4 rakamını ekranda gösteren diğer rakamlar yerine * işareti koyan programı yazınız

Console.WriteLine("Kredi Kartı numarasını girin: ");
string kart = Console.ReadLine();

int numara = kart.Length;

string yıldızNumara = "";

for (int i = 0; i < numara; i++)
{
    yıldızNumara += "*";
}
yıldızNumara += kart.Substring(numara - 4);

Console.WriteLine("Kart " + yıldızNumara);

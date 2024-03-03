// Klavyeden sıfır girilinceye kadar girilen sayıların kendisini ve karesini ekrana yazdıran program

int sonuc = 0;
int deger;
do
{
    Console.WriteLine("Sayı girin: ");
    deger = Convert.ToInt32(Console.ReadLine());

    if (deger != sonuc)
    {
        Console.WriteLine("Girilen Sayi " + deger + " Karesi: " + (deger * deger));
    }

}
while (deger != sonuc);

Console.WriteLine("0 Basıldı Programdan çıkıldı ");

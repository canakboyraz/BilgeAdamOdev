// Örnek 5: Bir adet 10 elemanlı elemanlarını rastgele girilen dizi tanımlayın. Bu dizi içerisindeki elemanların toplamını, ortalamasını ve son elemanını ekrana yazdırın.

int[] ilkDizi = new int[10];
Random rnd = new Random();
for (int i = 0; i < ilkDizi.Length; i++)
{
    ilkDizi[i] = rnd.Next(1, 10);
}

foreach (int i in ilkDizi)
{
    Console.Write(i + " ");
}
int toplam = 0;
Console.WriteLine();
Console.WriteLine();

foreach (int i in ilkDizi)
{
    toplam = toplam + i;
}

Console.WriteLine("Toplam: " + toplam);
Console.WriteLine("Ortalama: " + toplam/ilkDizi.Length);
Console.WriteLine("Son Sayı: " + ilkDizi[ilkDizi.Length-1]);

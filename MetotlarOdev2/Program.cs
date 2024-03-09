// Örnek 4: 10 elemanlı bir adet dizi tanımlayınız. birinciDizi'yi ikinci bir dizi oluşturup kopyalayınız.

int[] ilkDizi = new int[10];
Random rnd = new Random();
for (int i = 0; i < ilkDizi.Length; i++)
{
    ilkDizi[i] = rnd.Next(1, 10);
}

foreach (var item in ilkDizi)
{
    Console.Write(item + " ");
}


int[] ikinciDizi = new int[ilkDizi.Length];
Array.Copy(ilkDizi,ikinciDizi,ikinciDizi.Length);

Console.WriteLine();
Console.WriteLine(new string('*', 30));

foreach (int i in ikinciDizi)
{
    Console.Write(i + " ");
}
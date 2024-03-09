// Örnek 3: Int türünde bir dizi tanımlayalım içerisinde 10 eleman olsun 10 elemandan 2 tanesini 2 yapın dizi içerisindeki 2'nin ilk index'ini ve son index'ini ekrana yazdırın.

int[] dizi = new int[10];
Random rnd = new Random();
for (int i = 0; i < dizi.Length; i++)
{
    dizi[i] = rnd.Next(1,10);
}

// İlk 2'nin indeksini bulma
int ilkIndex = Array.IndexOf(dizi, 2);

if (ilkIndex != -1)
{
    Console.WriteLine("İlk 2'nin indeksi: " + ilkIndex);
}
else
{
    Console.WriteLine("Dizide 2 değeri bulunamadı.");
}

// Son 2'nin indeksini bulma
int sonIndex = Array.LastIndexOf(dizi, 2);

if (sonIndex != -1)
{
    Console.WriteLine("Son 2'nin indeksi: " + sonIndex);
}
else
{
    Console.WriteLine("Dizide 2 değeri bulunamadı.");
}

foreach (int i in dizi)
{
    Console.Write(" " + i);
}


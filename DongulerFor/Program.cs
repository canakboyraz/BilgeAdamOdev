// 5 e tam bölünen ama 7 e tam bölünmeyen sayılar

int sonuc = 0;

for (int i = 1; i <= 100; i++)
{
    if (i %5 == 0)
    {
        if (i %7 != 0)
        {
            sonuc = sonuc + i;
            Console.WriteLine("İstenilen sayi: " + i);
        }
        
    }

}

Console.WriteLine("Sonuc: " + sonuc);

// 5 10 15 20 

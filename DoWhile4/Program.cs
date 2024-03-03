// Do-While Örnek 2: Kullanıcı tarafından girilen 10 sayıdan kaç tanesinin 3 basamaklı olduğunu bulan program.



using System;

int sayac = 0;
int sonuc = 0;

do
{
    Console.WriteLine("Sayı Giriniz");
    int sayi = Convert.ToInt32(Console.ReadLine());
    sonuc++;

    if (sayi >= 100 && sayi <= 999)
    {
        sayac++;
    }

} while (sonuc < 10);

Console.WriteLine($"Girilen 10 sayıdan {sayac} tanesi 3 basamaklıdır.");
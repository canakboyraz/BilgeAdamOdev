// Kullanıcıdan alınan 3 sayıdan en büyüğünü bulan ve ekrana yazan algoritma ve program

/*
* 1. Adım: Başla
* 2. Adım: Kullanicidan sayi1, sayi2, sayi3 öğren.
* 3. Adım: Eğer sayi1 > sayi2 ve sayi1 > sayi3 ise Ekrana Yaz ("sayi1 en büyük sayıdır")
*          Aksi Halde Eğer sayi2 > sayi1 ve sayi2 > sayi3 ise Ekrana Yaz ("sayi2 en büyük sayıdır")
*          Aksi Halde Eğer Eğer sayi3 > sayi1 ve sayi3 > sayi2 ise Ekrana Yaz ("sayi3 en büyük sayıdır")
*          Aksi Halde, Ekrana Yaz("Sayilar Eşittir")
* 4. Adım: Bitir         
*/



using System;

Console.Write("Lütfen 1. sayı girin  ");
int sayi1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Lütfen 2. sayı girin  ");
int sayi2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Lütfen 3. sayı girin  ");
int sayi3 = Convert.ToInt32(Console.ReadLine());

if (sayi1 > sayi2 && sayi1 > sayi3)
{
    Console.WriteLine("sayi1 en büyük sayıdır");
}
else if (sayi2 > sayi1 && sayi2 > sayi3)
{
    Console.WriteLine("sayi2 en büyük sayıdır");
}
else if (sayi3 > sayi1 && sayi3 > sayi2)
{
    Console.WriteLine("sayi3 en büyük sayıdır");
}
else
{
    Console.WriteLine("Sayılar Eşittir");
}
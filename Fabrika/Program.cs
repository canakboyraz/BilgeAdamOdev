//2)Bir fabrikada sabit maaşla çalışan işçiler, aile durumlarına göre ek maaş almaktadır.Bekar olanlar sadece maaş, evli ve çocuğu olmayanlar % 3 ek maaş, çocuk sayısı 1 olanlar % 5 ek maaş, çocuk sayısı 2 olanlar % 10 ek maaş, çocuk sayısı 3 ve daha fazla olanlar ise % 15 kadar ek maaş almaktadır. Bu göre, kullanıcıdan işçinin maaşı ve çocuk sayısını isteyerek, gerekli hesaplamayı yapıp ekrana yazdıran program.


/* Try - Catch

Console.WriteLine("Lütfen maaşını giriniz: ");
double maas = Convert.ToDouble(Console.ReadLine);

Console.Write("Lütfen Evli için 'e' Bekar için 'b' basın ");
string personel = Console.ReadLine();

if (personel == "e")
{
    try
    {
        Console.Write("Lütfen çocuk sayısını girin ");
        int sayi = Convert.ToInt32(Console.ReadLine());

        if (sayi == 0)
        {
            Console.WriteLine("Maaşınız: " + maas);
        }
        else if (sayi == 1)
        {
            Console.WriteLine("Maaşınız: " + (maas * 1.05));
        }
        else if (sayi == 2)
        {
            Console.WriteLine("Maaşınız: " + (maas * 1.10));
        }
        else if (sayi >= 3)
        {
            Console.WriteLine("Maaşınız: " + (maas * 1.20));
        } 

    }
    catch(Exception ex)
    {
        {
            Console.WriteLine("Hatalı işlem lütfen tekrar deneyin.");
            Console.WriteLine(ex.Message);

        }

    }
    
}
else
{
    {
        Console.WriteLine("Maaşınız: " + maas);
    }
}
*/

tekrar:
Console.WriteLine("Lütfen maaşını giriniz: ");
double maas = 0;
try
{
    maas = Convert.ToDouble(Console.ReadLine());
}
catch (FormatException ex)
{
    Console.WriteLine("Geçersiz bir maaş değeri girdiniz.");
    Console.WriteLine("Hata: " + ex.Message);
    goto tekrar;
}

Console.Write("Lütfen Evli için 'e' Bekar için 'b' basın ");
string personel = Console.ReadLine();

if (personel == "e")
{
    tekrar1:
    try
    {
        
        Console.Write("Lütfen çocuk sayısını girin ");
        int sayi = Convert.ToInt32(Console.ReadLine());

        if (sayi == 0)
        {
            Console.WriteLine("Maaşınız: " + maas);
        }
        else if (sayi == 1)
        {
            Console.WriteLine("Maaşınız: " + (maas * 1.05));
        }
        else if (sayi == 2)
        {
            Console.WriteLine("Maaşınız: " + (maas * 1.10));
        }
        else if (sayi >= 3)
        {
            Console.WriteLine("Maaşınız: " + (maas * 1.20));
        }
    }
    catch (Exception ex)
    {
        Console.WriteLine("Hatalı işlem lütfen tekrar deneyin.");
        Console.WriteLine(ex.Message);
        goto tekrar1;
    }
}
else
{
    Console.WriteLine("Maaşınız: " + maas);
}





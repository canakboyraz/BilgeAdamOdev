Console.WriteLine("Lütfen faktöriyel hesaplanması için sayı giriniz");
int sayi = Convert.ToInt32(Console.ReadLine());
int toplam = 1;

if (sayi == 0)
{
    Console.WriteLine("Faktöriyel: 1" );
}
else if(sayi < 0)
{
    Console.WriteLine("Negatif sayının faktöriyel hesabı yapılmaz");
}
else 
{ 
    while (sayi != 1)
    {
        toplam = toplam * sayi;
        sayi = sayi - 1; // sayi--
    }
    Console.WriteLine("Faktöriyel: " + toplam);   
}


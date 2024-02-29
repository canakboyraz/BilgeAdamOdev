
int toplacift = 0;
int toplatek = 0;

for (int i = 0; i < 300; i++)
{
    if (i %2 == 0)
    {
        toplacift = toplacift + i;
    }
    else
    {
        toplatek = toplatek + i;
    }
}

Console.WriteLine("Toplam tekler: " + toplatek + "  Toplam çift: " + toplacift);

if (toplatek > toplacift)
{
    Console.WriteLine("Teklerin toplamı Çiftlerin Toplamından büyüktür.");
}
else if (toplatek < toplacift)
{
    Console.WriteLine("Çiftlerin toplamı teklerin toplamından büyüktür.");
}
else
{
    Console.WriteLine("Birbirine eşittir.");
}
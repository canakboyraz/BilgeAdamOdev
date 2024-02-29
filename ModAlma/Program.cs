for (int i = 1; i < 50; i++)
{
    int a = ((i * 3) + 2);
    if (a %5 == 0)
    {
        Console.WriteLine("3 katından 2 fazlası: " + a + " => Tam bölünür " + i);
    }
    else
    {
        Console.WriteLine("3 katından 2 fazlası: " + a + " => Tam bölünmez " + i);
    }
}
Console.Read();
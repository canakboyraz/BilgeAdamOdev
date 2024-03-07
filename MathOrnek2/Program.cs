//Örnek 2: Kullanıcı tarafından girilen double türünden kilo değerini tamsayıya yuvarlayan programı yazınız.

Console.WriteLine("Kilo girin: ");
double kilo = Convert.ToDouble(Console.ReadLine());

int yKilo = (int)Math.Round(kilo);

Console.WriteLine("Yuvarlanmış Kilo: " +  yKilo);
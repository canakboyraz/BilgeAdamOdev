// Kullanıcıdan alınan kenar uzunluklarına göre dikdörtgen çizen Program

Console.WriteLine("Uzunluk girin: ");
int uzunluk = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Genişlik girin: ");
int genişlik = Convert.ToInt32(Console.ReadLine());

for (int i = 0; i < uzunluk; i++)
{
	for (int a = 0; a < genişlik; a++)
	{	
		Console.Write(" *");
	}
	Console.WriteLine(" ");
}

//
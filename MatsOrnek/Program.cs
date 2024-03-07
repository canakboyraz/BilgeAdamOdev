// Örnek 1: Kullanıcı tarafından girilen bir sayının kullanıcı tarafından girilen kuvvetini alıp ekrana yazınız

Console.WriteLine("Sayı girin: ");
double sayi = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Kuvvet girin: ");
int kuvvet = Convert.ToInt32(Console.ReadLine());

double sonuc = Math.Pow(sayi, kuvvet);

Console.WriteLine($"{sayi} sayısının {kuvvet}. kuvveti: {sonuc}");

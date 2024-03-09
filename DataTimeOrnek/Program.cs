// ÖRnek 1: Ekrana sistemin anlık zaman ve saat bilgisini gg.aa.yyyy ss:dd formatında yazan program.

DateTime now = DateTime.Now;
string zaman = now.ToString("dd.MM.yyyy HH:mm");
Console.WriteLine("Sistem zamanı: " + zaman);


// ÖRnek 2: Ekrana sistemin anlık zaman ve saat bilgisini gg.aa.yyyy gün formatında yazan program.
DateTime now1 = DateTime.Now;
string zaman1 = now.ToString("dd.MM.yyyy dddd");
Console.WriteLine("Sistem zamanı: " + zaman1);

// ÖRnek 5: Ekrana aşağıdaki vereceğim formatlarda çıktı alınız.
/* 03.06.2022
* Haziran 2022
* 3 Haziran           
*/

DateTime tarih = new DateTime(2022, 6, 3);

// 03.06.2022
string format1 = tarih.ToString("dd.MM.yyyy");
Console.WriteLine(format1);

// Haziran 2022
string format2 = tarih.ToString("MMMM yyyy");
Console.WriteLine(format2);

// 3 Haziran
string format3 = tarih.ToString("d MMMM");
Console.WriteLine(format3);
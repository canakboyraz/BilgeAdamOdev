// See Kullanıcıdan alının ad,soyad ve yaş bilgilerini "benim adım ..... soyadım ...... ve yaşım .....'tır" şeklinde ekranda gösteren programı yazınız

using System.Diagnostics.Metrics;
using System;

Console.WriteLine("Adınızı girin: ");
string ad = Console.ReadLine();

Console.WriteLine("Soyad girin: ");
string soyad = Console.ReadLine();

Console.WriteLine("Yas girin: ");
string yas = Console.ReadLine();

Console.WriteLine($"\nbenim adım {ad} soyadım {soyad} ve yaşım {yas} 'tır");

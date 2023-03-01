// See https://aka.ms/new-console-template for more information

using System.Diagnostics;

string isim, soyad,tc_no, x, miktar;
int miktarr;
int bakiye = 500;
Console.WriteLine("sırasıyla: isminizi, soyadınızı ve tc no. giriniz");
isim = Console.ReadLine();
soyad = Console.ReadLine();
tc_no = Console.ReadLine();

Console.WriteLine("para yatırmak istiyorsanız 1 - para çekmek istiyorsanız 2 " +
                  "yazınız ve en son miktarınız yazınız.");
x = Console.ReadLine();
miktar = Console.ReadLine();
miktarr = Convert.ToInt32(miktar);
switch (x)
{
    case "1":
        bakiye += miktarr;
        Console.WriteLine("son bakiyeniz " + bakiye);
        Console.WriteLine("paranız başarıyla eklendi");
        break;
    case "2":
        bakiye -= miktarr;
        Console.WriteLine("son bakiyeniz " + bakiye);
        Console.WriteLine("paranızı başarıyla çektiniz");
        break;
}

Console.ReadLine();
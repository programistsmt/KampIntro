using ClassMetotDemo;
using System.Runtime.CompilerServices;

Musteri musteri1 = new Musteri();
Musteri musteri2 = new Musteri();
Musteri musteri3 = new Musteri();
Musteri musteri4 = new Musteri();
MusteriManager p = new MusteriManager();

musteri1.ID = 1;
musteri1.AdSoyad = "Hande UÇAR";
musteri1.DTarihi = 1990;

musteri2.ID = 2;
musteri2.AdSoyad = "Samet UÇAR";
musteri2.DTarihi = 1989;

musteri3.ID = 3;
musteri3.AdSoyad = "Defne UÇAR";
musteri3.DTarihi = 2019;

musteri4.ID = 1;
musteri4.AdSoyad = "Asya UÇAR";
musteri4.DTarihi = 2021;

Musteri[] Musteriler = { musteri1, musteri2, musteri3, musteri4 };
//buraya kadar classlara ait değişkenleri girdik.

Console.WriteLine("Müşterileri listelemek için L'ye basın");
string tercih;
tercih = Console.ReadLine();

switch (tercih)
{
    case "L":
    p.MusteriListele(Musteriler);

         break;
    default:
        break;
}
int tus;
Console.WriteLine("Yanlış tuşa bastınız.Lütfen yeni müşteri eklemek için 1'e basın");
tus = Convert.ToInt16(Console.ReadLine());
if (tus == 1)
{
    p.MusteriEkleme();
    
}
else
{
    Console.WriteLine("Yanlış tuşa bastınız");
}


Console.WriteLine("Lütfen müşteri silmek için S harfine basın");
string tercih1;
tercih1 = Console.ReadLine();
switch (tercih1)
{
    case "S":
        p.MusteriSil();

        break;
    default:
        break;
}
Console.WriteLine("Hoşçakalın");














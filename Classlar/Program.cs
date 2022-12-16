// önce oluşturduğumuz sınıf türünde arac1,arac2,arac3 değişkenlerini tanımlıyoruz.
// sonra da bu değişkenlere sınıf içerisinde bulunan değerleri atıyoruz.


otomobil arac1 = new otomobil();
arac1.Marka = "Hyundai";
arac1.Model = "Accent";
arac1.Yil = 1999;
otomobil arac2 = new otomobil();
arac2.Marka = "infinity";
arac2.Model = "fx35";
arac2.Yil = 2005;

otomobil arac3 = new otomobil();
arac3.Marka = "Fiat";
arac3.Model = "Egea";
arac3.Yil = 2010;
//şimdi de bu değişkenleri içinde barındıran araclar isminde bir array değişkeni tanımlıyoruz. 
otomobil[] araclar = { arac1, arac2, arac3 };
foreach (otomobil x in araclar)
{
    Console.WriteLine(x.Marka + "  " + x.Model + "  " + x.Yil);
}

class otomobil
{
    public string? Marka { get; set; }
    public string? Model { get; set; }
    public int Yil { get; set; }
}
class Suv
{
    public string? Marka { get; set; }
    public string? Model { get; set; }
    public int Yil { get; set; }
}

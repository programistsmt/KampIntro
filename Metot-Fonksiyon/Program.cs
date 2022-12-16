PuanTablosu takim1 = new PuanTablosu();
PuanTablosu takim2 = new PuanTablosu();
PuanTablosu takim3 = new PuanTablosu();
bool y = false;
switch (y)
{
    case true:
        takim1.Siralama = 1;
        takim1.TakimAdi = "Arsenal";
        takim1.Puan = 83;

        takim2.Siralama = 2;
        takim2.TakimAdi = "City";
        takim2.Puan = 81;

        takim3.Siralama = 3;
        takim3.TakimAdi = "Liverpool";
        takim3.Puan = 79;
        break;
      case false:
        takim1.Siralama = 1;
        takim1.TakimAdi = "Galatasaray";
        takim1.Puan = 83;

        takim2.Siralama = 2;
        takim2.TakimAdi = "Fenerbahçe";
        takim2.Puan = 81;

        takim3.Siralama = 3;
        takim3.TakimAdi = "Bjk";
        takim3.Puan = 79;
        break;
}
PuanTablosu[] takimlar = { takim1, takim2, takim3 };
foreach (PuanTablosu siralama in takimlar)
{
    Console.WriteLine(siralama.Siralama + "- " + siralama.TakimAdi + " " + siralama.Puan);
}
SampiyonuBelirle sampiyon = new SampiyonuBelirle();
sampiyon.Sampiyon(takim1);
    public class PuanTablosu
{

    public int Siralama { get; set; }
    public string? TakimAdi { get; set; }
    public int Puan { get; set; }

}
public class SampiyonuBelirle
{
    public void Sampiyon(PuanTablosu x)
    {

        Console.WriteLine("Şampiyon" + " " + x.TakimAdi);

    }
}
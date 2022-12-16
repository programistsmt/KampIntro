string[] superlig = new string[] { "Gs", "Fb", "Bjk","ts" };
string[] premier = new string[] { "Liverpool", "Arsenal", "City" };
int x = 3;
int y = 2;
bool p = false;
if (x > y)
{
    for (int i = 0; i < 4; i++)
    {
        Console.WriteLine(superlig[i]);

    }
}
else if (p == true)
{
    for (int i = 0; i < 3; i++)
    {
        Console.WriteLine(premier[i]);

    }
}
else
{
    Console.WriteLine("hoşcakal");
}
//forech döngüler için daha mantıklı örneği aşağıda
int[] x = new int[] { 1, 2 };
string z = ("gs");

foreach (int y in x)
{
    Console.WriteLine(y + " " + z);
}

// aşağıdaki örnek de döngüler için iyi bir örnek
int x = (5);
int y = (3);
int[] p = { 1, 2, 3, 4, 5 };
for (int i = 1; i < p.Length; i++)
{
    Console.WriteLine(x * y);
}
foreach (int z in p)
{
    int t = (z * y);
    if (t > 14)
    {
        Console.WriteLine("merhaba");
    }
}
// switch-case ifadesi bir verinin alabileceği değerler arasında case işlemi yapılmasıdır.if-else bloğuna benzer ama karşılaştırma yapmaz.kesin ifadeler
// için geçerlidir.Örneğin; telefonda 1 tuşu için şurası 2 tuşu için şurası gibi
int number = 1;
switch (number)
{
    case 1:
        Console.WriteLine("Durum 1");
        break;
    case 2:
        Console.WriteLine("Durum 2");
        break;
    default:
        Console.WriteLine("Varsayılan durum");
        break;
}
// Ternary operatöörü if-else bloğu ile aynı işi yapar Uzun hali
if (sayi1 == 10)
{
    Console.WriteLine("Eşittir");
}
else
{
    Console.WriteLine("Eşit Değil");
}

// Kısa Hali  - ternary operatörü
string result = sayi1 == 10 ? "Eşittir" : "Eşit değil";
Console.WriteLine(result);

// örnek tek satır ekranda görmek için ve teksatır
Console.WriteLine(sayi1 == 10 ? "Eşitti" : "Eşit değil");
//
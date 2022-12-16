using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KampIntro
{
    public class PuanTablosu
    {
       
        public int Siralama { get; set; }
        public string TakimAdi { get; set; }
        public int Puan { get; set; }

    }
    public class SampiyonuBelirle
    {
        public void Sampiyon(PuanTablosu x)
        {

            Console.WriteLine("Şampiyon" + " " + x.TakimAdi);

        }
    }
}

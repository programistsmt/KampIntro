using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMetotDemo
{
    public class MusteriManager
    {
        

        public void MusteriListele(Musteri[] x)
        {
            foreach (Musteri z in x)
            {
                Console.WriteLine(z.ID + " " + z.AdSoyad + " " + z.DTarihi);
            }


        }

        public void MusteriEkleme()
        {
            
            Musteri yeni = new Musteri();
            Console.WriteLine("Lütfen müşteri ID'sini giriniz..");
            yeni.ID = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Lütfen müşteri ad-soyad giriniz..");
            yeni.AdSoyad = Console.ReadLine();
            Console.WriteLine("Lütfen müşteri doğum tarihini giriniz..");
            yeni.DTarihi = Convert.ToInt16(Console.ReadLine());


            Console.WriteLine("Yeni müşteri eklenmiştir");
            Console.WriteLine("------------------------");
            Console.WriteLine(yeni.ID + " " + yeni.AdSoyad + " " +yeni.DTarihi);


        }

        public void MusteriSil()
        {

            Console.WriteLine("Mevcut müşteri silinmiştir");

        }
      







    }
}

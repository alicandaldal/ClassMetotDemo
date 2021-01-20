using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class MusteriManager
    {
        public void ekle(Musteri musteriBilgi)
        {
            Console.WriteLine("-----------------------------------------");
            Console.WriteLine("Eklenen Müşteri :" + musteriBilgi.MusteriAd + " " + musteriBilgi.MusteriSoyad);
        }
        public void listele(Musteri[] musteriListeleme)
        {
            Console.WriteLine("---------------Müşteri Listesi-------------------");

            foreach (Musteri musteriBilgi in musteriListeleme)
            {
                Console.WriteLine("Sıra No : " + musteriBilgi.MusteriId);
                Console.WriteLine("İsim : " + musteriBilgi.MusteriAd);
                Console.WriteLine("Soyisim : " + musteriBilgi.MusteriSoyad);
                Console.WriteLine("Tc No : " + musteriBilgi.MusteriTc);
                Console.WriteLine("Tel : " + musteriBilgi.MusteriTel);
                Console.WriteLine("Cinsiyet : " + musteriBilgi.MusteriCinsiyet);
                Console.WriteLine("-----------------------------------------");


            }    
         
        }

        public void sil(Musteri musteriBilgi)
        {
            Console.WriteLine("Silinen müşteri: " + musteriBilgi.MusteriAd + " " + musteriBilgi.MusteriSoyad);
        }
    }
}

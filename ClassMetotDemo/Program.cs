using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();
            musteri1.MusteriId = 1;
            musteri1.MusteriAd = "Ahmet";
            musteri1.MusteriSoyad = "Demir";
            musteri1.MusteriTc = 14232345341;
            musteri1.MusteriTel = 05399999029;
            musteri1.MusteriCinsiyet = "Erkek";

            Musteri musteri2 = new Musteri();
            musteri2.MusteriId = 2;
            musteri2.MusteriAd = "Selin";
            musteri2.MusteriSoyad = "Kaya";
            musteri2.MusteriTc = 45261345345;
            musteri2.MusteriTel = 05233452129;
            musteri2.MusteriCinsiyet = "Kadın";

            Musteri musteri3 = new Musteri();
            musteri3.MusteriId = 3;
            musteri3.MusteriAd = "Faruk";
            musteri3.MusteriSoyad = "Sönmez";
            musteri3.MusteriTc = 45261345345;
            musteri3.MusteriTel = 05986372888;
            musteri3.MusteriCinsiyet = "Erkek";


            MusteriManager islemler = new MusteriManager();
            islemler.ekle(musteri1);
            islemler.sil(musteri3);

            Musteri[] musteriBilgi = new Musteri[] { musteri1, musteri2, musteri3 };
            islemler.listele(musteriBilgi);
        }
    }
}

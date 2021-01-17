using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();
            musteri1.Ad = "Serkan";
            musteri1.SoyAd = "Kocaman";
            musteri1.Yas = 24;

            Musteri musteri2 = new Musteri();
            musteri2.Ad = "Eren";
            musteri2.SoyAd = "Ceylan";
            musteri2.Yas = 22;

            Musteri musteri3 = new Musteri();
            musteri3.Ad = "Emre";
            musteri3.SoyAd = "Arslan";
            musteri3.Yas = 36;

            Musteri[] musteriler = new Musteri[] {musteri1, musteri2, musteri3 };

            MusteriManager musteriManager = new MusteriManager();
            foreach (var musteri in musteriler)
            {
                musteriManager.MusteriEkle(musteri);
            }
            Console.WriteLine("///////////////////////////////////////////////////");
            foreach (var musteri in musteriler)
            {
                musteriManager.MusteriListele(musteri);
            }
            Console.WriteLine("///////////////////////////////////////////////////");
            foreach (var musteri in musteriler)
            {
                musteriManager.MusteriSil(musteri);
            }
            
        }
    }
}

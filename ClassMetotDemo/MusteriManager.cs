using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class MusteriManager
    {
        public void MusteriEkle(Musteri musteri)
        {
            Console.WriteLine("Müşteri Eklendi!" + " " + musteri.Ad + " " + musteri.SoyAd + " " + musteri.Yas);
        }
        public void MusteriSil(Musteri musteri)
        {
            Console.WriteLine("Müşteri Silindi!" + " " + musteri.Ad + " " + musteri.SoyAd + " " + musteri.Yas);
        }
        public void MusteriListele(Musteri musteri)
        {
            Console.WriteLine("Müşteri Listelendi!" + " " + musteri.Ad + " " + musteri.SoyAd + " " + musteri.Yas);
        }
    }
}

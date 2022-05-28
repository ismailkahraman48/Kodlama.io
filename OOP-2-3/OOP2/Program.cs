using System;

namespace OOP2
{
    class Program
    {
        static void Main(string[] args)
        {
            GercekMusteri musteri1 = new GercekMusteri();
            musteri1.MusteriNo = "125123";
            musteri1.Adi = "ismail";
            musteri1.Soyadi = "Kahraman";
            musteri1.TcNo = "4671212312";
            musteri1.Id = 908701;

            TuzelMusteri musteri2 = new TuzelMusteri();
            musteri2.Id = 125123123;
            musteri2.MusteriNo = "86987689";
            musteri2.SirketAdi = "kodlama.io";
            musteri2.VergiNo = "88882222";



            Musteri musteri3 = new GercekMusteri();  //Kalıtımda baba Musteridir her iki musteri türünüde tutabilir

            Musteri musteri4 = new TuzelMusteri();

            MusteriManager musteriManager = new MusteriManager(); //musteri manager fonksiyonunu kullanmak için program.cs de tanımladık

            musteriManager.Ekle(musteri1);
            musteriManager.Ekle(musteri2);




        }
    }
}

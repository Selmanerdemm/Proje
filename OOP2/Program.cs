using System;

namespace OOP2
{
    class Program
    {
        
        //SOLID tekniği
        static void Main(string[] args)
        {
            //Gerçek Müşteri
            GercekMusteri musteri1 = new GercekMusteri();
            musteri1.Id = 1;
            musteri1.MusteriNo = "12345";
            musteri1.Adi = "Selman";
            musteri1.Soyadi = "Erdem";
            musteri1.TcNo = "000000000";


            // Tüzel Müşteri(şirket vs.)
            TuzelMusteri musteri2 = new TuzelMusteri();
            musteri2.Id = 2;
            musteri2.MusteriNo = "54321";
            musteri2.SirketAdi = "Kodlama.io";
            musteri2.VergiNo = "222222222";


            //---------------------------

            Musteri musteri3 = new GercekMusteri();
            Musteri musteri4 = new TuzelMusteri();

            CustomerManager customerManager = new CustomerManager();
            customerManager.Add(musteri1);
            customerManager.Add(musteri2);



        }
    }
}

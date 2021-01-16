using System;

namespace Class
{
    class Program
    {
        static void Main(string[] args)
        {
            string adi = "Selman";
            int yas = 22;

            Kurs kurs1 = new Kurs(); // Class tanımlama.
            kurs1.KursAdi = "C#";   // Classın İçindeki Değerler.
            kurs1.Egitmen = "Selman Erdem";
            kurs1.İzlenmeOrani = 68;

            Kurs kurs2 = new Kurs(); 
            kurs2.KursAdi = "Java";   
            kurs2.Egitmen = "Cemal Erdem";
            kurs2.İzlenmeOrani = 64;

            Kurs kurs3 = new Kurs(); 
            kurs3.KursAdi = "Python";   
            kurs3.Egitmen = "Furkan Erdem";
            kurs3.İzlenmeOrani = 87;

            Kurs kurs4 = new Kurs();
            kurs4.KursAdi = "C++";
            kurs4.Egitmen = "Mehmet Mustafa Erdem";
            kurs4.İzlenmeOrani = 100;



            //Console.WriteLine(kurs1.KursAdi + " " + kurs1.Egitmen);

            // İçinde Kurs Olan Arreyleri Getir
            Kurs[] kurslar = new Kurs[] {kurs1,kurs2,kurs3,kurs4};

            foreach (var kurs in kurslar)
            {
                Console.WriteLine(kurs.KursAdi + " : " + kurs.Egitmen + " : " + kurs.İzlenmeOrani);
            }
        }
    }

    class Kurs
    {
        public string KursAdi { get; set; }

        public string Egitmen { get; set; }

        public int İzlenmeOrani { get; set; }
    }
}

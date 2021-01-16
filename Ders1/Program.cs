using System;

namespace Ders1
{
    class Program
    {
        static void Main(string[] args)
        {
            // type safety = tip güvenliği

            // bool = Doğru-Yanlış Kontrol Eder.
            bool sistemGirisYapmismi = false;
            double dolarDun = 7.35;
            double dolarBugun = 7.45;

            if (dolarDun>dolarBugun)
            {
                Console.WriteLine("Azalış Butonu");
            }
            else if (dolarDun<dolarBugun)
            {
                Console.WriteLine("Artış butonu");
            }
            else
            {
                Console.WriteLine("Dolar Değişmedi");
            }


            if (sistemGirisYapmismi == true)
            {
                Console.WriteLine("Kullanıcı Ayarları Butonu");
            }
            else
            {
                Console.WriteLine("Giriş Yap Butonu");
            }
           


        }
    }
}

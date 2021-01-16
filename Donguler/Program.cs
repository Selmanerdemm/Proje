using System;

namespace Donguler
{
    class Program
    {
        static void Main(string[] args)
        {
            

            // Array = Diziler
            string[] kurslar = new string[] {"Yazılım Geliştirici Yetiştirme Kampı","Programlamaya Başlangıç İçin Temel Kurs","Java Öğrenme","Python","C# Öğrenme"};


            // For Döngüsü
            for (int i = 0; i < kurslar.Length; i++) // Length = Kaç adet eleman varsa döngüyü o kadar döndürür
            {
                Console.WriteLine(kurslar[i]);
            }

            Console.WriteLine("-------For Bitti----------");

            foreach (string kurs in kurslar) // Arrayler için uygulanır.Arreyleri tek tek dolaş demek.
            {
                Console.WriteLine(kurs);
            }


            Console.WriteLine("Sayfa Sonu - footer");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace Methotlar
{
    class SepetManager
    {
        // naming convention - Yazım kuralı metot büyük harfle başlar
        // syntax
        public void Ekle(Urun urun) // İmza
        {
            Console.WriteLine("Tebrikler. Sepete Eklendi : " + urun.Adi);

        }

        public void Ekle2(string urunAdi, string Aciklama, double fiyat, int stokAdedi)
        {
            Console.WriteLine("Tebrikler. Sepete Eklendi : " + urunAdi);

        }
    }
}

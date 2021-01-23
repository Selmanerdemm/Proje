using System;
using System.Collections.Generic;
using System.Text;

namespace OOP2
{
    //Coorporate - Tüzel
    // inheritance - miras - tüzel müşteri bir müşteri demek
    class TuzelMusteri:Musteri 
    {
        public string SirketAdi { get; set; }
        public string VergiNo { get; set; }
    }
}

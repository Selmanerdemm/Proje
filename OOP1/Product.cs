using System;
using System.Collections.Generic;
using System.Text;

namespace OOP1
{
    // snippet - TabTab
    class Product

    {
        //PK
        public int Id  { get; set; }

        // referans alanı FK
        public int CategoryId { get; set; } 

        public string ProductName { get; set; }

        //fiyat
        public double UnitPrice { get; set; }

        // ürün stok adedi
        public int UnitsInStock { get; set; }


        

    }
}

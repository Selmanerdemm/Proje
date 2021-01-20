using System;
using System.Collections.Generic;
using System.Text;

namespace GenericsIntro
{
    class MyList<T> // T -- tüm veri tiplerini yazdırmak için -- hangi veri türü verilirse onu dön
    {
        T[] items;

        //constructor
        public MyList()
        {
            items = new T[0];
        }
        public void Add(T item) // item -- eleman
        {
            // Geçici Dizi
            T[] tempArray = items;
            items = new T[items.Length+1];
            for (int i = 0; i < tempArray.Length; i++)
            {
                items[i] = tempArray[i];
            }

            items[items.Length - 1] = item;
        }
    }
}

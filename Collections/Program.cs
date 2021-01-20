using System;
using System.Collections.Generic;

namespace Collections
{
    class Program
    {
        static void Main(string[] args)
        {
            //string[] names = new string[] { "Selman", "Cemal", "Furkan", "Mustafa" };
            //Console.WriteLine(names[0]);
            //Console.WriteLine(names[1]);
            //Console.WriteLine(names[2]);
            //Console.WriteLine(names[3]);

            //names = new string[5];
            //names[4] = "ilker";
            //Console.WriteLine(names[4]);


            List<string> names2 = new List<string> { "Selman","Cemal","Furkan","Mustafa" };
            Console.WriteLine(names2[0]);
            Console.WriteLine(names2[1]);
            Console.WriteLine(names2[2]);
            Console.WriteLine(names2[3]);
            names2.Add("Filiz");
            Console.WriteLine(names2[4]);
            Console.WriteLine(names2[0]);
            
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace methodcallprat
{//ha ide rakod a calc-ot akkor más program ból is meghívható
    class Program
    {
        static void Main(string[] args)
        {
             int a = 10, b = 20;

            //Console.WriteLine(a+b);
            calc(ref a, b); //method meghívása

            b = calc(ref a, b);
            Console.WriteLine("asd {0}", b);
            Console.ReadKey();
        }
        static int calc( ref int  a , int b) //method (ha nem írjuk oda a  refeket akkor nem írja át) ( ha oda írod akkor át is írja)
        {
            Console.WriteLine(a + b);
            a = 100;
            Console.WriteLine(a + b);
            return b + 50; // vissza adja a b+50 értéket
        }
    }
}

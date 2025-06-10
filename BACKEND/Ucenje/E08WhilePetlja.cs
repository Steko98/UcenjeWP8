using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ucenje
{
    class E08WhilePetlja
    {
        public static void Izvedi()
        {
            Console.WriteLine("E08WhilePetlja");
            Console.WriteLine("******************************");

            while (true)
            {
                Console.WriteLine("Ispis iz beskonacne petlje nakon cega je break");
                break;
            }

            int i = 10;

            while (i < 10)
            {
                Console.WriteLine(i++);
            }

            Console.WriteLine("******************************");

            i = 0;
            while (i < 10)
            {
                Console.WriteLine(++i);
            }

            Console.WriteLine("******************************");

            i = 0;
            int j = 1;
            //while (i < 10 && j == 1)
            //{
            //    Console.WriteLine(i);
            //}

            Console.WriteLine("******************************");

            while (i>10)
            {
                while (j==1)
                {
                    goto labela;
                }
            }

            labela:
                Console.WriteLine("Gotov");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ucenje
{
    class E07ForPetlja
    {
        public static void Izvedi()
        {
            Console.WriteLine("E07ForPetlja");

            //Console.WriteLine("Hrvatska-Ceska 5:1");
            //Console.WriteLine("Hrvatska-Ceska 5:1");
            //Console.WriteLine("Hrvatska-Ceska 5:1");
            //Console.WriteLine("Hrvatska-Ceska 5:1");
            //Console.WriteLine("Hrvatska-Ceska 5:1");
            //Console.WriteLine("Hrvatska-Ceska 5:1");
            //Console.WriteLine("Hrvatska-Ceska 5:1");
            //Console.WriteLine("Hrvatska-Ceska 5:1");
            //Console.WriteLine("Hrvatska-Ceska 5:1");
            //Console.WriteLine("Hrvatska-Ceska 5:1");

            //Console.WriteLine("*******************");

            //for (int i = 0; i<10; i++)
            //{
            //    Console.WriteLine("Hrvatska-Ceska 5:1");
            //}

            //Console.WriteLine("*******************");

            //for (int i = 0; i < 10; i++)
            //{
            //    Console.WriteLine("{0}.",i+1);
            //}

            //Console.WriteLine("*******************");

            //Console.WriteLine((100/2)*100+100/2);
            //Console.WriteLine(100/2 * (100 + 1));

            //int suma = 0;
            //for (int i = 0; i < 100; i++)
            //{
            //    suma = suma + i + 1;
            //}
            //Console.WriteLine(suma);

            //Console.WriteLine("*******************");

            //for (int i = 10; i > 0; i--)
            //{
            //    Console.WriteLine(i);
            //}

            //Console.WriteLine("*******************");

            //for (int i = 0; i < 91; i+=5)
            //{
            //    Console.WriteLine(i);
            //}

            //Console.WriteLine("*******************");

            //for (int i = 79; i < 124; i++)
            //{
            //    if (i % 2 == 0)
            //    {
            //        Console.WriteLine(i);
            //    }
            //}

            //Console.WriteLine("*******************");

            //int odKuda = 2, doKuda = 8;
            //for (int i = odKuda; i < doKuda; i++)
            //{
            //    Console.WriteLine(i);
            //}

            //Console.WriteLine("*******************");

            //string grad = "Osijek";
            //for (int i = 0; i < grad.Length; i++)
            //{
            //    Console.WriteLine(grad[i]);
            //}

            //Console.WriteLine("*******************");

            //for (int i = 1; i <= 10; i++)
            //{
            //    for (int j = 1; j <= 10; j++)
            //    {
            //        Console.Write("{0} ", i*j);
            //    }
            //    Console.WriteLine();
            //}

            Console.WriteLine("*******************");

            for (int i = 0; i < 10; i++)
            {
                if (i == 2)
                {
                    continue;
                }

                if (i == 7)
                {
                    break;
                }

                Console.WriteLine(i);
            }

            Console.WriteLine("*******************");

            for (; ; )
            {
                Console.WriteLine("{0} {1} {2} {3} {4} {5}", new Random().Next(), new Random().Next(), new Random().Next(), new Random().Next(), new Random().Next(), new Random().Next());
                Thread.Sleep(500);
            }

            Console.WriteLine("*******************");
        }
    }
}

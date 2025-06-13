using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ucenje
{
    class E12Metode
    {
        public static void Izvedi()
        {
            Console.WriteLine("E12Metode");
            Console.WriteLine("************************************************");

            Tip1();
            //for (int i = 0; i < 10; i++)
            //{
            //    Tip1();
            //}

            Tip2(2);
            Tip2(7);

            Tip2(2, 6);

            Tip3();
            string s = Tip3();
            Console.WriteLine(s);

            Console.WriteLine("****************************************************");

            for (int i = 0; i <= 100; i++)
            {
                if (prim(i))
                {
                    Console.WriteLine(i);
                }
            }

            Console.WriteLine("****************************************************");

            Console.WriteLine(ucitajCijeliBroj("Unesi 1.broj") + ucitajCijeliBroj("Unesi 2.broj"));





















        }

         //kraj metode Izvedi

        static void Tip1()
        {
            Console.WriteLine("Ispis iz metode tipa 1 koja je bez nacina pristupa vidljiva samo u klasi");
            Console.WriteLine("************");
            Console.WriteLine("Edunova");
            Console.WriteLine("************");
        }

        private static void Tip2(int i)
        {
            Console.WriteLine("Primio sam broj {0}",i);
        }

        private static void Tip2(int i, int j)
        {
            Console.WriteLine("Zbroj je {0}", i+j);
        }

        protected static string Tip3()
        {
            Console.WriteLine("Izvodim metodu Tip3");
            return "Web programiranje";
        }

        public static bool prim(int broj)
        {
            for (int i = 2; i < broj; i++)
            {
                if (broj % i == 0)
                {
                    return false;
                }
            }

            return true;
        }

        public static int ucitajCijeliBroj(string poruka)
        {
            while (true)
            {
                Console.Write(poruka + ": ");
                try
                {
                    return int.Parse(Console.ReadLine());
                }
                catch
                {
                    Console.WriteLine("Pokuajte ponovo");
                }
            }
        }





    } //kraj klase
}

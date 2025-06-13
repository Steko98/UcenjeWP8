using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ucenje
{
    class E11TryCatch
    {
        public static void Izvedi()
        {
            Console.WriteLine("Try Catch");

            Console.Write("Unesi broj: ");


            int broj = 0;

            //try
            //{
            //    broj = int.Parse(Console.ReadLine());
            //}
            //catch
            //{
            //    Console.WriteLine("Nije broj");
            //}

            //Console.WriteLine(broj+1);

            //while (true)
            //{
            //    try
            //    {
            //        Console.Write("Unesi broj: ");
            //        broj = int.Parse(Console.ReadLine());
            //        break;
            //    }
            //    catch
            //    {
            //        Console.WriteLine("Niste unijeli broj.");
            //    }
            //}
            //Console.WriteLine(broj + 1);

            //2 cijela broja ispisuje njihov zbroj

            int prviBroj, drugiBroj;

            while (true)
            {
                try
                {
                    Console.Write("Unesi prvi broj: ");
                    prviBroj = int.Parse(Console.ReadLine());
                    break;
                }
                catch
                {
                    Console.WriteLine("Niste unijeli prvi broj.");
                }
            }

            while (true)
            {
                try
                {
                    Console.WriteLine("Unesi drugi broj: ");
                    drugiBroj = int.Parse(Console.ReadLine());
                    break;
                }
                catch
                {
                    Console.WriteLine("Niste unijeli drugi broj.");
                }
            }

            Console.WriteLine("Rezultat je {0}", prviBroj + drugiBroj);
        }
    }
}

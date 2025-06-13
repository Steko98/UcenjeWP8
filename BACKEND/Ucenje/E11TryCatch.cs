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







            //int prviBroj, drugiBroj;

            //while (true)
            //{
            //    try
            //    {
            //        Console.Write("Unesi prvi broj: ");
            //        prviBroj = int.Parse(Console.ReadLine());
            //        break;
            //    }
            //    catch
            //    {
            //        Console.WriteLine("Niste unijeli prvi broj.");
            //    }
            //}

            //while (true)
            //{
            //    try
            //    {
            //        Console.WriteLine("Unesi drugi broj: ");
            //        drugiBroj = int.Parse(Console.ReadLine());
            //        break;
            //    }
            //    catch
            //    {
            //        Console.WriteLine("Niste unijeli drugi broj.");
            //    }
            //}

            //Console.WriteLine("Rezultat je {0}", prviBroj + drugiBroj);






            string unosniNizZnakova;
            int b = 0;

            while (true)
            {
                Console.Write("Unesi broj: ");
                unosniNizZnakova = Console.ReadLine().Trim();

                if (unosniNizZnakova.Length > 9)
                {
                    Console.WriteLine("Unijeli ste predugacak niz znakova");
                    continue;
                }
                try
                {
                    b = int.Parse(unosniNizZnakova);
                    if (broj > 10000)
                    {
                        Console.WriteLine("Unijeli ste prevelik broj.");
                        continue;
                    }
                    break;
                }
                catch
                {
                    Console.WriteLine("Niste unijeli broj.");
                }
            }
            Console.WriteLine("Uneseni broj je: {0}", broj);














        }
    }
}

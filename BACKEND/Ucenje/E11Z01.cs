using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ucenje
{
    class E11Z01
    {
        public static void Izvedi()
        {
            Console.WriteLine("E11Z01");

            int b;

            while (true)
            {
                Console.Write("Unesi cijeli broj: ");
                string uneseno = Console.ReadLine().Trim();

                if (uneseno.Length > 9)
                {
                    Console.WriteLine("Unijeli ste predug niz znakova");
                    continue;
                }
                try
                {
                    b = int.Parse(uneseno);
                    if (b > 10000)
                    {
                        Console.WriteLine("Unijeli ste prevelik broj");
                        continue;
                    }
                    break;
                }
                catch
                {
                    Console.WriteLine("Niste unijeli broj.");
                }

                Console.WriteLine();
            }

        }
    }
}

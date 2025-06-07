using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Subota1
{
    internal class S03ParNepar
    {
        public static void Izvedi()
        {
            Console.WriteLine("S03");

            Console.Write("Unesite cijeli broj: ");
            int broj = int.Parse(Console.ReadLine());
            if (broj % 2 == 0) {Console.WriteLine("Vaš broj je paran!");
            } else
            {
                Console.WriteLine("Vaš broj je neparan!");
            }
        }
    }
}

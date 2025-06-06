using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ucenje
{
    class E05UvjetnoGrananjeSwitch
    {
        public static void Izvedi()
        {
            Console.WriteLine("E05");

            Console.Write("Unesi ocjenu: ");
            int broj = int.Parse(Console.ReadLine());

            switch (broj)
            {
                case 1:
                    Console.WriteLine("Nedovoljan");
                    break;
                case 2:
                    Console.WriteLine("Dovoljan");
                    break;
                case 3:
                    Console.WriteLine("Dobar");
                    break;
                case 4:
                    Console.WriteLine("Vrlo dobar");
                    break;
                case 5:
                    Console.WriteLine("Izvrstan");
                    break;
                case 6:
                case 7:
                    Console.WriteLine("I to bi mogle biti ocjene ali nisu");
                    break;
                default:
                    Console.WriteLine("Nije ocjena");
                    break;
            }
        }
    }
}

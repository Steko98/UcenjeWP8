using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ucenje
{
    class E10ForEach
    {
        public static void Izvedi()
        {
            Console.WriteLine("E10ForEach");
            Console.WriteLine("****************************");

            Console.Write("Unesi ime grada: ");
            string grad = Console.ReadLine();

            foreach (char z in grad)
            {
                Console.WriteLine(z);
            }

            Console.WriteLine("****************************");

            int[] brojevi = {1,57,34,12,754,234,12,675,213,6754,87,23,12};
            foreach (int i in brojevi)
            {
                Console.WriteLine(i);
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ucenje
{
    internal class E13Rekurzija
    {
        public static void Izvedi()
        {
            Console.WriteLine(zbroj(100));
        }

        private static int zbroj(int i)
        {
            if ( i == 1)
            {
                return 1;
            }
            return i + zbroj(i - 1);
        }
    }
}

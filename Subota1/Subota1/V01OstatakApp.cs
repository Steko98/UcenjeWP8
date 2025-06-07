using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace Subota1
{
    internal class V01OstatakApp
    {
        public static void Izvedi()
        {
            Console.WriteLine("Operator modulo %");
            Console.Write("Unesi prvi (cijeli) broj: ");
            int prviBroj = int.Parse(Console.ReadLine());
            Console.Write("Unesi drugi (cijeli) broj: ");
            int drugiBroj = int.Parse(Console.ReadLine());
            Console.WriteLine("Ostatak je {0}", prviBroj%drugiBroj);

        }
    }
}

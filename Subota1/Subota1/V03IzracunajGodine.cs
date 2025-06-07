using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace Subota1
{
    internal class V03IzracunajGodine
    {
        public static void Izvedi()
        {
            Console.Write("Unesite svoju godinu rođenja: ");
            int godinaRodenja = int.Parse(Console.ReadLine());
            Console.WriteLine("Imate {0} godina", 2025-godinaRodenja);
        }
    }
}

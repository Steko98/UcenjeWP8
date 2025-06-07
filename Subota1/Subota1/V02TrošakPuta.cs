using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Subota1
{
    internal class V02TrošakPuta
    {
        public static void Izvedi()
        {
            Console.WriteLine("Putni troškovi");
            Console.Write("Unesite potrošnju vozila: ");
            double potrosnjaVozila = double.Parse(Console.ReadLine());
            Console.Write("Unesite duljinu puta u kilometrima: ");
            int duljinaPuta = int.Parse(Console.ReadLine());
            Console.Write("Unesite cijenu goriva u eurima: ");
            double cijenaGoriva = double.Parse(Console.ReadLine());
            Console.WriteLine("Cijena puta je: {0}", ((duljinaPuta/100)*potrosnjaVozila)*cijenaGoriva);
        }
    }
}

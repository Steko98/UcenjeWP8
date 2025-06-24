using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Ucenje.E18GSALE
{
    // Ekstenzije su metode koje možemo nakačiti na bilo koji tip podatka za koji je ekstenzija napisana
    public static class Ekstenzije
    {

        public static void EdunovaProvjera(this string s)
        {
            Console.WriteLine(s.Substring(2, 4));
        }

        public static int Broj(this IObrada obrada)
        {
            string s = obrada.Metoda();
            return s.Length;
        }

    }
}

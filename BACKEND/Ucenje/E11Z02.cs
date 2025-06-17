using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ucenje
{
    internal class E11Z02
    {
        public static void Izvedi()
        {
            Console.WriteLine("Zadatak");

            string ime = Pomocno.UcitajString("Unesi ime osobe");
            if (!Pomocno.IsCijeliBroj(ime))
            {
                Console.WriteLine(ime);
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ucenje.E17Vjezbanje
{
    public class Zadatak3
    {
        private int brojIzvodenja = 0;

        public void Izvedi()
        {
            brojIzvodenja++;
            int broj = Pomocno.UcitajCijeliBroj("Unesi cijeli broj");
           if (broj < 0)
            {
                Console.WriteLine("Broj {0} je negativan", broj);
            }
           else if (broj > 0)
            {
                Console.WriteLine("Broj {0} je pozitivan", broj);
            } else
            {
                Console.WriteLine("Unijeli ste {0} (nula)", broj);
            }
            Console.WriteLine("Završio {0}. izvodenje", brojIzvodenja);
        }
    }
}

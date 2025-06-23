using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ucenje.E17Vjezbanje
{
    public class Zadatak10
    {
        private int brojIzvodenja = 0;

        public void Izvedi()
        {
            brojIzvodenja++;

            int duzinaNiza = Pomocno.UcitajCijeliBroj("Unesite dužinu niza");
            int[] niz = new int[duzinaNiza];

            for (int i = 0; i < duzinaNiza; i++)
            {
                niz[i] = Pomocno.UcitajCijeliBroj(string.Format("Unesite {0}. broj u niz", i + 1));
            }

            Array.Sort(niz);
            Console.WriteLine(string.Join(" ", niz));

            Console.WriteLine("Završio {0}. izvodenje", brojIzvodenja);
        }
    }
}

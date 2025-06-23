using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ucenje.E17Vjezbanje
{
    public class Zadatak4
    {
        private int brojIzvodenja = 0;

        public void Izvedi()
        {
            brojIzvodenja++;
            int suma = 0;

            Console.Write("Unesite dužinu vašeg niza: ");
            int duzinaNiza = int.Parse(Console.ReadLine());
            int[] niz = new int[duzinaNiza];

            for (int i = 0; i < duzinaNiza; i++)
            {

                int broj = Pomocno.UcitajCijeliBroj(string.Format("Unesite {0}. broj u niz", i + 1));

                niz[i] = broj;
            }

            for (int i = 0; i < niz.Length; i++)
            {
                suma += niz[i]; 
            }

            Console.WriteLine("Zbroj svih elemenata niza je: {0}", suma);
            Console.WriteLine("Završio {0}. izvodenje", brojIzvodenja);

        }
    }
}

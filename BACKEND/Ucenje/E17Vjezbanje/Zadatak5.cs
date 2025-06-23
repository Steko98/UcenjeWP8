using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ucenje.E17Vjezbanje
{
    public class Zadatak5
    {
        private int brojIzvodenja = 0;

        public void Izvedi()
        {
            brojIzvodenja++;
            double suma = 0;

            Console.Write("Unesite broj ocjena: ");
            int brojOcjena = int.Parse(Console.ReadLine());
            int[] ocjene = new int[brojOcjena];

            for (int i = 0; i < brojOcjena; i++)
            {

                int ocjena = Pomocno.UcitajCijeliBroj(string.Format("Unesite {0}. ocjenu", i + 1));
                while (ocjena < 1 || ocjena > 5)
                {
                    ocjena = Pomocno.UcitajCijeliBroj("Unesite ocjenu između 1 i 5");

                }
                ocjene[i] = ocjena;
            }

            for (int i = 0; i < ocjene.Length; i++)
            {
                suma += ocjene[i];
            }

            double prosjek = suma / brojOcjena;

            Console.WriteLine("Prosjek ocjena je: {0}", Math.Round(prosjek, 2));
            Console.WriteLine("Završio {0}. izvodenje", brojIzvodenja);

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ucenje.E17Vjezbanje
{
    public class Zadatak6
    {
        private int brojIzvodenja = 0;

        public void Izvedi()
        {
            brojIzvodenja++;

            int prviBroj = 0;
            int drugiBroj = 1;
            int stalakZaVrijednost = 0;
            int duzinaNiza = Pomocno.UcitajCijeliBroj("Unesite broj znamenki niza");

            while (duzinaNiza < 1)
            {
                Console.WriteLine("Ne mogu napisati manje od jedne znamenke!");
                duzinaNiza = Pomocno.UcitajCijeliBroj("Pokušajte ponovno");
            }

            for (int i = 0; i < duzinaNiza; i++)
            {
                Console.WriteLine("{0}", prviBroj); 
                stalakZaVrijednost = prviBroj + drugiBroj;
                prviBroj = drugiBroj;
                drugiBroj = stalakZaVrijednost;
            }
            Console.WriteLine("Završio {0}. izvodenje", brojIzvodenja);
        }

    }
}


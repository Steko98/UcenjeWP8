using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ucenje.E17Vjezbanje
{
    public class Zadatak7
    {
        private int brojIzvodenja = 0;

        public void Izvedi()
        {
            brojIzvodenja++;

            string tekst = Pomocno.UcitajString("Unesite tekst");
            string obrnutiTekst = "";

            for (int i = tekst.Length - 1; i >= 0; i--)
            {
                obrnutiTekst += tekst[i];
            }

            Console.WriteLine(obrnutiTekst);
            Console.WriteLine("Završio {0}. izvodenje", brojIzvodenja);
        }
    }
}

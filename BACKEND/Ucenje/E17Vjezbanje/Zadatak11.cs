using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ucenje.E17Vjezbanje
{
    public class Zadatak11
    {
        private int brojIzvodenja = 0;

        public void Izvedi()
        {
            brojIzvodenja++;

            Console.WriteLine("1. Zbrajanje");
            Console.WriteLine("2. Oduzimanje");
            Console.WriteLine("3. Množenje");
            Console.WriteLine("4. Dijeljenje");

            int odabir = Pomocno.UcitajCijeliBroj("Odaberite operaciju");

            while (odabir < 1 && odabir > 4)
            {
                Console.WriteLine("Neispravan unos");
                odabir = Pomocno.UcitajCijeliBroj("Odaberite operaciju");
            }

            switch (odabir)
            {
                case 1:
                    Zbrajanje();
                    break;
                case 2:
                    Oduzimanje();
                    break;
                case 3:
                    Mnozenje();
                    break;
                case 4:
                    Dijeljenje();
                    break;
                default:
                    break;
            }

            Console.WriteLine("Završio {0}. izvodenje", brojIzvodenja);
        }

        private void Zbrajanje()
        {
            int prviBroj = Pomocno.UcitajCijeliBroj("Unesi prvi broj");
            int drugiBroj = Pomocno.UcitajCijeliBroj("Unesi drugi broj");
            Console.WriteLine("{0} + {1} = {2}", prviBroj, drugiBroj, prviBroj + drugiBroj);
        }
        private void Oduzimanje()
        {
            int prviBroj = Pomocno.UcitajCijeliBroj("Unesi prvi broj");
            int drugiBroj = Pomocno.UcitajCijeliBroj("Unesi drugi broj");
            Console.WriteLine("{0} - {1} = {2}", prviBroj, drugiBroj, prviBroj - drugiBroj);
        }
        private void Mnozenje()
        {
            int prviBroj = Pomocno.UcitajCijeliBroj("Unesi prvi broj");
            int drugiBroj = Pomocno.UcitajCijeliBroj("Unesi drugi broj");
            Console.WriteLine("{0} * {1} = {2}", prviBroj, drugiBroj, prviBroj * drugiBroj);
        }
        private void Dijeljenje()
        {
            int prviBroj = Pomocno.UcitajCijeliBroj("Unesi prvi broj");
            int drugiBroj = Pomocno.UcitajCijeliBroj("Unesi drugi broj");
            double rezultat = (double)prviBroj / drugiBroj;
            Console.WriteLine("{0} / {1} = {2}", prviBroj, drugiBroj, rezultat);
        }


    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ucenje.E17Vjezbanje
{
    public class Zadatak9
    {
        private int brojIzvodenja = 0;

        public void Izvedi()
        {
            brojIzvodenja++;

            Console.WriteLine("1. Celzijus u Fahrenheit");
            Console.WriteLine("2. Fahrenheit u Celzijus");

            int odabir = Pomocno.UcitajCijeliBroj("Odaberite koverziju");

            while (odabir != 1 && odabir!= 2)
            {
                Console.WriteLine("Odaberite 1 - Celzijus u Fahrenheit ili 2 - Fahrenheit u Celzijus");
                odabir = Pomocno.UcitajCijeliBroj("Odaberite konverziju");
            }

            switch (odabir)
            {
                case 1:
                    CuF();
                    break;
                case 2:
                    FuC();
                    break;
                default:
                    break;
            }

            Console.WriteLine("Završio {0}. izvodenje", brojIzvodenja);
        }

        private void CuF()
        {
            decimal temperatura = Pomocno.UcitajDecimalniBroj("Unesite temperaturu u Celzijusima");
            decimal tempF = temperatura * 9 / 5 + 32;
            Console.WriteLine("{0}°C je {1}°F", temperatura, tempF);
        }
        private void FuC()
        {
            decimal temperatura = Pomocno.UcitajDecimalniBroj("Unesite temperaturu u Fahrenheitima");
            decimal tempC = (temperatura - 32) *5 / 9;
            Console.WriteLine("{0}°F je {1}°C", temperatura, tempC);
        }
    }
}

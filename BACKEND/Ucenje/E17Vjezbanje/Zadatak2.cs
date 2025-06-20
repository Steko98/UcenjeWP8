using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ucenje.E17Vjezbanje
{
    public class Zadatak2
    {
        private int brojIzvodenja = 0;

        public void Izvedi()
        {
            brojIzvodenja++;
            int dp = Pomocno.UcitajCijeliBroj("Unesi duljinu pravokutnika");
            int sp = Pomocno.UcitajCijeliBroj("Unesi sirinu pravokutnika");
            Console.WriteLine("Površina je {0}*{1}={2}m2", dp, sp, dp * sp);
            Console.WriteLine("Završio {0}. izvodenje", brojIzvodenja);
        }
    }
}

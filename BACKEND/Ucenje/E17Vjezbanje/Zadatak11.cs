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




            Console.WriteLine("Završio {0}. izvodenje", brojIzvodenja);
        }
    }
}

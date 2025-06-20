using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ucenje.E17Vjezbanje
{
    public class Zadatak1
    {
        private int brojIzvodenja = 0;
        
        public void Izvedi()
        {
            brojIzvodenja++;
            int pb = Pomocno.UcitajCijeliBroj("Unesi prvi broj");
            int db = Pomocno.UcitajCijeliBroj("Unesi drugi broj");
            Console.WriteLine("{0}+{1}={2}",pb,db,pb+db);
            Console.WriteLine("Završio {0}. izvodenje", brojIzvodenja);
        }
    }
}

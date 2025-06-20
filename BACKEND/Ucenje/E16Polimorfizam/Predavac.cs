using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ucenje.E16Polimorfizam
{
    public class Predavac : Osoba
    {
        public string? IBAN { get; set; }

        public override void Greska(string poruka)
        {

        }
        public override string Pozdravi()
        {
            return Ime + " " + IBAN;
        }
    }
}

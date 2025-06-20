using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ucenje.E16Polimorfizam
{
    public class Polaznik : Osoba
    {
        public string Telefon { get; set; }


        public override void Greska(string poruka)
        {
            
        }

        public override string Pozdravi()
        {
            return new StringBuilder()
                .Append("Dobar dan ").Append(Ime).Append(" , polazniče").Append(Telefon).ToString();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ucenje.E15Nasljedivanje
{
    public class Polaznik : Osoba
    {
        public string Telefon { get; set; } = "";

        //method override

        public override string ToString()
        {
            return base.ToString() + " " + Telefon;

        }

        public override bool Equals(object? obj)
        {
            if (obj == null) return false;
            var p = obj as Polaznik;

            if (p.Ime.Equals(this.Ime) &&
                p.Prezime.Equals(Prezime) &&
                p.Telefon.Equals(Telefon)) return true;

            return false;
                
            
        }
    }
}

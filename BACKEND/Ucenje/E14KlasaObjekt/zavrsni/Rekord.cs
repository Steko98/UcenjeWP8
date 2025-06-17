using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ucenje.E14KlasaObjekt.zavrsni
{
    class Rekord
    {
        public int Sifra { get; set; }
        public string? Naziv { get; set; }
        public Igrac? Igrac { get; set; } = new Igrac();
        public Turnir Turnir { get; set; } = new Turnir();
    }
}

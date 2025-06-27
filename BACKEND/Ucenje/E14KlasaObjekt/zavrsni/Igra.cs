using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ucenje.E14KlasaObjekt.zavrsni
{
    class Igra : Entitet
    {
        public DateTime Datum { get; set; }
        public Turnir Turnir { get; set; } = new Turnir();
    }
}

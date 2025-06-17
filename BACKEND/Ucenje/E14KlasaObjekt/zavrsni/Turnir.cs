using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ucenje.E14KlasaObjekt.zavrsni
{
    class Turnir
    {
        public int Sifra { get; set; }
        public string? Ime { get; set; }
        public DateTime DatumPocetka { get; set; }
        public DateTime DatumZavrsetka { get; set; }
        public Igra[] Igre { get; set; }
    }
}

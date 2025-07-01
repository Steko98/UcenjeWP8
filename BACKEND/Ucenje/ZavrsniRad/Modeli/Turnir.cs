using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ucenje.E14KlasaObjekt.Modeli
{
    public class Turnir : Entitet
    {
        public string? Ime { get; set; }
        public DateTime DatumPocetka { get; set; }
        public DateTime? DatumZavrsetka { get; set; }
        public List<Igra> Igre { get; set; }
    }
}

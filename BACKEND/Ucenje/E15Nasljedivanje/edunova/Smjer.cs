using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ucenje.E15Nasljedivanje.edunova;

namespace Ucenje.E15KlasaObjekt.edunova
{
    public class Smjer : SvojstvoNaziv
    {
        public decimal Cijena  { get; set; }
        public DateTime? DatumPokretanja { get; set; }
        public bool Aktivan { get; set; }

    }
}

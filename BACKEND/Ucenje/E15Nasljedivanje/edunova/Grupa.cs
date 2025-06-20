using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ucenje.E15Nasljedivanje.edunova;

namespace Ucenje.E15KlasaObjekt.edunova
{
    class Grupa : SvojstvoNaziv
    {
        public Smjer Smjer { get; set; } = new Smjer();
        public string? Predavac { get; set; }
        public Polaznik[]? Polaznici { get; set; }
    }
}

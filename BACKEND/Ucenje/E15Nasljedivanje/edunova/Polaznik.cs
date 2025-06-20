using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ucenje.E15Nasljedivanje.edunova;

namespace Ucenje.E15KlasaObjekt.edunova
{
    public class Polaznik : Entitet
    {
        public string Ime { get; set; } = "";
        public string Prezime { get; set; } = "";
        public string? Email { get; set; }

    }
}

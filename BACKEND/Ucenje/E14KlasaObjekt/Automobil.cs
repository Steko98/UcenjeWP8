using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ucenje.E14KlasaObjekt
{
    public class Automobil
    {
        public int sifra { get; set; }
        public string? Proizvodjac { get; set; }
        public DateTime? DatumProizvodnje { get; set; }
        public double Cijena { get; set; }
        public bool Automatik { get; set; }
    }
}

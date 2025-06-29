using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ucenje.E14KlasaObjekt.Modeli;

namespace Ucenje.ZavrsniRad
{
    public class ObradaIgra
    {
        public List<Igra> Igre { get; set; }

        public ObradaIgra()
        {
            Igre = new List<Igra>();
        }
    }
}

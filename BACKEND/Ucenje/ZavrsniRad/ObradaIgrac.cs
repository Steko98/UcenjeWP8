using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ucenje.E14KlasaObjekt.Modeli;

namespace Ucenje.ZavrsniRad
{
    public class ObradaIgrac
    {
        public List<Igrac> Igraci { get; set; }

        public ObradaIgrac()
        {
            Igraci = new List<Igrac>();
        }
    }
}

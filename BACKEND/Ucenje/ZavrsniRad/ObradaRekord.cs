using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ucenje.E14KlasaObjekt.Modeli;

namespace Ucenje.ZavrsniRad
{
    public class ObradaRekord
    {
        public List<Rekord> Rekordi { get; set; }

        public ObradaRekord()
        {
            Rekordi = new List<Rekord>();
        }
    }
}

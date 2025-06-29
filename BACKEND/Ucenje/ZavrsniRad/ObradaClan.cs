using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ucenje.E14KlasaObjekt.Modeli;

namespace Ucenje.ZavrsniRad
{
    public class ObradaClan
    {
        public List<Clan> Clanovi { get; set; }

        public ObradaClan()
        {
            Clanovi = new List<Clan>();
        }
    }
}

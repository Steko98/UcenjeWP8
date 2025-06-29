using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ucenje.E14KlasaObjekt.Modeli
{
    public class Clan
    {
        public Igra Igra { get; set; } = new Igra();
        public Igrac Igrac { get; set; } = new Igrac();
        public int? BrojBodova { get; set; }
        public bool Pobjeda { get; set; }
    }
}

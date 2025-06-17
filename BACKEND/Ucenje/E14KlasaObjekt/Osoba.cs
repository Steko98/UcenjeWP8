using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ucenje.E14KlasaObjekt
{
    internal class Osoba
    {
        //svojstva
        public int Sifra { get; set; }
        public string? Ime { get; set; }
        public string Prezime { get; set; } = "";
        public DateTime? DatumRodenja { get; set; }

        //metode
        public void IspisiImeIPrezime()
        {
            Console.WriteLine(this.Ime + " " + Prezime);
        }

        public static void Primjer()
        {
            Console.WriteLine("Primjer staticne metode");
        }
    }
}

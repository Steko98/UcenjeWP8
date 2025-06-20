using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ucenje.E16Polimorfizam
{
    public abstract class Osoba
    {

        public abstract string Pozdravi();

        public string Ime { get; set; } = "";
        public string Prezime { get; set; } = "";

        public virtual void Log(string poruka)
        {
            Console.WriteLine("Iz virtualne " + poruka);
        }

        public abstract void Greska(string poruka);
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ucenje.E18GSALE
{
    public class EdunovaObrada<T> : IObrada where T : Entitet
    {
        public T? Entitet { get; set; }

        public string Metoda()
        {
            return "";
            return "Edunova";
        }

        public void OdradiPosao()
        {
            Posao();
        }

        [Obsolete("Više nemoj koristiti")]
        public void Posao()
        {
            Console.WriteLine(Entitet?.Sifra);
        }

    }
}

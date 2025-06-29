using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ucenje.E19KonzolnaAplikacija;

namespace Ucenje.ZavrsniRad
{
    public class Izbornik
    {
        public ObradaTurnir ObradaTurnir { get; set; }
        public ObradaIgrac ObradaIgrac { get; set; }
        public ObradaIgra ObradaIgra { get; set; }
        public ObradaRekord ObradaRekord { get; set; }
        public ObradaClan ObradaClan { get; set; }

        public Izbornik()
        {
            Console.WriteLine("***********************************");
            Console.WriteLine("***********************************");
            Console.WriteLine("********** Catan App v1. **********");
            Console.WriteLine("***********************************");
            Console.WriteLine("***********************************");

            UcitajIzbornik();
        }

        private void UcitajIzbornik()
        {
            Console.WriteLine("*************************");
            Console.WriteLine("**** Glavni izbornik ****");
            Console.WriteLine("*************************");
            Console.WriteLine("1. Rad s igrama");
            Console.WriteLine("2. Pregled po igracima");
            Console.WriteLine("3. Pregled po turnirima");
            Console.WriteLine("4. Rekordi");
            Console.WriteLine("5. Izlaz iz programa");
            OdabirIzbornika();
        }
        private void OdabirIzbornika()
        {
            switch (Pomocno.UcitajRasponBroja("Odaberite stavku izbornika", 1, 5))
            {
                case 1:
                    Console.Clear();
                    //ObradaIgra.UcitajIzbornik();
                    UcitajIzbornik();
                    break;
                case 2:
                    Console.Clear();
                    //ObradaIgrac.UcitajIzbornik();
                    UcitajIzbornik();
                    break;
                case 3:
                    Console.Clear();
                    ObradaTurnir.UcitajIzbornik();
                    UcitajIzbornik();
                    break;
                case 4:
                    Console.Clear();
                    //ObradaRekord.UcitajIzbornik();
                    UcitajIzbornik();
                    break;
                case 5:
                    Console.WriteLine("Hvala na korištenju aplikacije, doviđenja!");
                    //SpremiPodatke();
                    break;
            }
        }
    }
}

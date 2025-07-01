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

        public void UcitajIzbornik()
        {
            Console.WriteLine("**** Pregled po igracima ****");
            Console.WriteLine("\n1. Popis igraca");
            Console.WriteLine("2. Pregled pojedinog igraca");
            Console.WriteLine("3. Statistika");
            Console.WriteLine("4. Povratak na glavni izbornik");
            OdabirIzbornika();
        }

        private void OdabirIzbornika()
        {
            switch (Pomocno.UcitajRasponBroja("\nOdaberite stavku izbornika", 1, 6))
            {
                case 1:
                    PopisIgraca();
                    UcitajIzbornik();
                    break;
                case 2:
                    //PregledPojedinogIgraca();
                    UcitajIzbornik();
                    break;
                case 3:
                    //PogledajStatistiku();
                    UcitajIzbornik();
                    break;
                case 4:
                    Console.Clear();
                    break;
            }
        }

        public void PopisIgraca()
        {
            //ispis svih igraca
            //mozda opcija rangiraj po nekoj statistici
            //mozda sastrane broj odigranih, broj pobjeda, postotak, mozda i rangirano
        }

        public void PregledPojedinogIgraca()
        {
            //odabir igraca sifrom
            //ispis imena, statistike
        }

    }


}

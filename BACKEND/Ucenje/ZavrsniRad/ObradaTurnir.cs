using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using Ucenje.E14KlasaObjekt.Modeli;

namespace Ucenje.ZavrsniRad
{
    public class ObradaTurnir
    {
        public List<Turnir> Turniri { get; set; }

        public ObradaTurnir()
        {
            Turniri = new List<Turnir>();
        }

        public void UcitajIzbornik()
        {
            Console.WriteLine("*************************");
            Console.WriteLine("**** Rad s turnirima ****");
            Console.WriteLine("*************************");
            Console.WriteLine("1. Pregled svih turnira");
            Console.WriteLine("2. Pregleda pojedinog turnira");
            Console.WriteLine("3. Dodaj turnir");
            Console.WriteLine("4. Uredi postojeći turnir");
            Console.WriteLine("5. Brisanje turnira");
            Console.WriteLine("6. Povratak na glavni izbornik");
            OdabirIzbornika();
        }

        private void OdabirIzbornika()
        {
            switch (Pomocno.UcitajRasponBroja("Odaberite stavku izbornika", 1, 6))
            {
                case 1:
                    PregledSvihTurnira();
                    UcitajIzbornik();
                    break;
                case 2:
                    PregledPojedinogTurnira();
                    UcitajIzbornik();
                    break;
                case 3:
                    DodajTurnir();
                    UcitajIzbornik();
                    break;
                case 4:
                    UrediTurnir();
                    UcitajIzbornik();
                    break;
                case 5:
                    ObrisiTurnir();
                    UcitajIzbornik();
                    break;
                case 6:
                    Console.Clear();
                    break;
            }
        }

        public void PregledSvihTurnira()
        {
            Console.WriteLine("******** Turniri ********");
            int redniBroj = 0;
            foreach (var t in Turniri)
            {
                Console.WriteLine(++redniBroj + ". " + t.Ime);
            }
            Console.WriteLine("*************************");
        }

        public void PregledPojedinogTurnira()
        {
            PregledSvihTurnira();
            var t = Turniri[Pomocno.UcitajRasponBroja("Odaberi redni broj turnira", 1, Turniri.Count) - 1];
            Console.WriteLine("*************************");
            Console.WriteLine("Detalji turnira:");
            Console.WriteLine("Šifra: " + t.Sifra);
            Console.WriteLine("Naziv: " + t.Ime);
            Console.WriteLine("Datum početka: " + t.DatumPocetka.ToString("dd. MM. yyyy."));
            Console.WriteLine("Datum završetka: " + t.DatumZavrsetka.Value.ToString("dd. MM. yyyy."));
            //sudionici
            //broj igara
            //najviše pobjeda, najbolji postotak, najviše bodova, najviše odigranih, itd.
            Console.WriteLine("*************************");
        }

        public void DodajTurnir()
        {
            Console.WriteLine("*************************");
            Console.WriteLine("Unesite podatke o turniru:");
            Turniri.Add(new()
            {
                Sifra = Pomocno.UcitajRasponBroja("Unesi šifru turnira", 1, int.MaxValue),
                Ime = Pomocno.UcitajString("Unesi naziv turnira"),
                DatumPocetka = Pomocno.UcitajDatum("Unesi datum početka turnira"),
                DatumZavrsetka = Pomocno.UcitajDatum("Unesi datum završetka turnira"),
            });
            Console.WriteLine("*************************");
        }

        public void UrediTurnir()
        {
            PregledSvihTurnira();
            var odabrani = Turniri[Pomocno.UcitajRasponBroja("Odaberi redni broj turnira",
                1, Turniri.Count) - 1];

            if (Pomocno.UcitajRasponBroja("1. Mjenjaš sve\n2. Pojedinačna promjena", 1, 2) == 1)
            {
                odabrani.Sifra = Pomocno.UcitajRasponBroja("Unesi šifru smjera", 1, int.MaxValue);
                odabrani.Ime = Pomocno.UcitajString("Unesi naziv turnira");
                odabrani.DatumPocetka = Pomocno.UcitajDatum("Unesi novi datum početka turnira");
                odabrani.DatumZavrsetka = Pomocno.UcitajDatum("Unesi novi datum završetka turnira");
            }
            else
            {
                switch (Pomocno.UcitajRasponBroja("1. Šifra\n2. Ime\n3. Datum početka\n4. Datum završetka\n", 1, 4))
                {
                    case 1:
                        odabrani.Sifra = Pomocno.UcitajRasponBroja("Unesi šifru smjera", 1, int.MaxValue);
                        break;
                    case 2:
                        odabrani.Ime = Pomocno.UcitajString("Unesi naziv smjera");
                        break;
                    case 3:
                        odabrani.DatumPocetka = Pomocno.UcitajDatum("Unesi novi datum početka turnira");
                        break;
                    case 4:
                        odabrani.DatumPocetka = Pomocno.UcitajDatum("Unesi novi datum završetka turnira");
                        break;
                }
            }
        }
        private void ObrisiTurnir()
        {
            PregledSvihTurnira();
            var odabrani = Turniri[Pomocno.UcitajRasponBroja("Odaberi redni broj turnira za obrisati",
                1, Turniri.Count) - 1];

            if (Pomocno.UcitajBool("Sigurno obrisati " + odabrani.Ime +"?"))
            {
                Turniri.Remove(odabrani);
            }
        }
    }
}

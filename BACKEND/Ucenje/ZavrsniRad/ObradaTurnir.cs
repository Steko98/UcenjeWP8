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
                    //UrediPostojeciTurnir();
                    UcitajIzbornik();
                    break;
                case 5:
                    //ObrisiTurnir();
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
                //DatumPocetka = Pomocno.UcitajDatum("Unesi datum početka turnira"),
                //DatumZavrsetka = Pomocno.UcitajDatum("Unesi datum završetka turnira"),
            });
            Console.WriteLine("*************************");
        }

        // napravit metodu Ucitaj Datum u Pomocno
        // napravit metode uredi i obrisi turnir







    }
}

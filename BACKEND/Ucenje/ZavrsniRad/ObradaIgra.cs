using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ucenje.E14KlasaObjekt.Modeli;

namespace Ucenje.ZavrsniRad
{
    public class ObradaIgra
    {
        public List<Igra> Igre { get; set; }

        public ObradaIgra()
        {
            Igre = new List<Igra>();
        }

        public void UcitajIzbornik()
        {
            Console.WriteLine("****** Rad s igrama *****");
            Console.WriteLine("1. Pregled igara po turniru");
            Console.WriteLine("2. Dodaj igru");
            Console.WriteLine("3. Uređivanje igre");
            Console.WriteLine("4. Brisanje igre");
            Console.WriteLine("5. Povratak na glavni izbornik");
            OdabirIzbornika();
        }
        private void OdabirIzbornika()
        {
            switch (Pomocno.UcitajRasponBroja("\nOdaberite stavku izbornika", 1, 5))
            {
                case 1:
                    //PregledPoTurniru();
                    UcitajIzbornik();
                    break;
                case 2:
                    //DodajIgru();
                    UcitajIzbornik();
                    break;
                case 3:
                    //UrediIgru();
                    UcitajIzbornik();
                    break;
                case 4:
                    //ObrisiIgru();
                    Console.Clear();
                    break;
                case 5:
                    Console.Clear();
                    break;
            }
        }

        public void PregledPoTurniru()
        {
            Console.WriteLine("***** Igre u turniru *****");
            
            //ispisati sve igre iz jednog turnira
            //vjv redni broj, datum, pobjednik, sudionici

            Console.WriteLine("*************************");
        }

        public void DodajIgru()
        {
            Console.WriteLine("*************************");
            Console.WriteLine("Unesite podatke o igri:");
            Igre.Add(new()
            {
                Sifra = Pomocno.UcitajRasponBroja("Unesi šifru turnira", 1, int.MaxValue),
                Datum = Pomocno.UcitajDatum("Unesi datum igre"),
            });

            //trebalo bi upisati igrace, pobjednika, bodove, a to je u clanovima


            Console.WriteLine("*************************");
        }

        public void UrediIgru()
        {
            // prvo odabrati turnir, zatim igru
            //urediti sve ili neki detalj
        }

        public void ObrisiIgru()
        {
            // prvo odabrati turnir, zatim igru
            // potvrda za obrisati
        }


    }
}

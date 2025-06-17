using System;
using System.Buffers;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Ucenje.E14KlasaObjekt
{
    internal class Program
    {
        public Program()
        {
            Console.WriteLine("Klasa/objekt");

            Osoba osoba = new Osoba();

            osoba.Sifra = 1;
            //osoba.Ime = "Pero"; namjerno ostavljeno null
            osoba.Prezime = "Peric";
            osoba.DatumRodenja = new DateTime(1980, 12, 7);

            //osoba.Sifra = Pomocno.UcitajCijeliBroj("Unesi sifru osobe");
            //osoba.Prezime = Pomocno.UcitajString("Unesi prezime osobe");
            //osoba.DatumRodenja = new DateTime(
            //    Pomocno.UcitajCijeliBroj("Unesi godinu rodenja"),
            //    Pomocno.UcitajCijeliBroj("Unesi mjesec rodenja"),
            //    Pomocno.UcitajCijeliBroj("Unesi dan rodenja")
            //    );

            Console.WriteLine(osoba.Prezime);
            Console.WriteLine(osoba.Ime);
            Console.WriteLine(osoba.Ime ?? "nije postavljeno");

            osoba.IspisiImeIPrezime(); // - ne staticna metoda s objekta
            // Osoba.IspisiImeIPrezime(); // - oov nebi mogli

            //osoba.Primjer(); - ne moze staticna metoda s objekta
            Osoba.Primjer(); // - staticnu metodu pozivamo s klase

            Osoba[] osobe = new Osoba[3];

            osobe[0] = new Osoba()
            {
                Ime = "Marija",
                Prezime = "Kat",
                Sifra = 2,
                DatumRodenja = new DateTime(1982, 1, 2)
            };
            osobe[1] = new()
            {
                Ime = "Ante"
            };
            osobe[2] = osoba;

            foreach (Osoba o in osobe)
            {
                Console.WriteLine(o.Ime);
            }

            Console.WriteLine(osoba.Mjesto?.Naziv ?? "Nije postavljeno");

            osoba.Mjesto = new()
            {
                Naziv = "Osijek",
                Zupanija = new Zupanija()
                {
                    Naziv = "OBZ",
                    Zupan = new()
                    {
                        Ime = "Natasa"
                    }
                }
            };
            Console.WriteLine(osoba.Mjesto?.Naziv??"Nije postavljeno");

            osoba.Ime = "Pero";
            //osoba.Mjesto.Zupanija = new Zupanija() { Naziv = "OBZ", Zupan = new() { Ime = "Natasa" } };

            Console.WriteLine(osoba.Ime);

            Console.WriteLine(osoba.Mjesto?.Zupanija.Naziv);

            Console.WriteLine(osoba.Mjesto?.Naziv);


            //napravit klasu automobil s 5 svojstava

            


        }

        public static void AutomobilZadatak()
        {
            Automobil automobil = new Automobil();
            automobil.sifra = 1;
            automobil.Proizvodjac = "Ford";
            automobil.DatumProizvodnje = new DateTime(1991,11,1);
            automobil.Automatik = false;
            automobil.Cijena = 14525.80;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ucenje.E17Vjezbanje
{
    public class Program
    {

        public Zadatak1 Zad1 { get; set; }
        public Zadatak2 Zad2 { get; set; }
        public Zadatak3 Zad3 { get; set; }
        public Zadatak4 Zad4 { get; set; }
        public Zadatak5 Zad5 { get; set; }
        public Zadatak6 Zad6 { get; set; }
        public Zadatak7 Zad7 { get; set; }
        public Zadatak8 Zad8 { get; set; }
        public Zadatak9 Zad9 { get; set; }
        public Zadatak10 Zad10 { get; set; }
        public Zadatak11 Zad11 { get; set; }
        public Program()
        {
            Zad1 = new Zadatak1();
            Zad2 = new Zadatak2();
            Zad3 = new Zadatak3();
            Zad4 = new Zadatak4();
            Zad5 = new Zadatak5();
            Zad6 = new Zadatak6();
            Zad7 = new Zadatak7();
            Zad8 = new Zadatak8();
            Zad9 = new Zadatak9();
            Zad10 = new Zadatak10();
            Zad11 = new Zadatak11();
            Izbornik();
        }

        private void Izbornik()
        {
            Console.WriteLine("\n******************************************");
            Console.WriteLine("*****************IZBORNIK*****************");
            Console.WriteLine("******************************************");
            Console.WriteLine("\n0. Izlaz");
            Console.WriteLine("1. Zbrajanje dvaju brojeva");
            Console.WriteLine("2. Izracun povrsine pravokutnika");
            Console.WriteLine("3. Provjera je li broj pozitivan, negativan ili nula");
            Console.WriteLine("4. Zbroj elemenata niza");
            Console.WriteLine("5. Prosjek ocjena");
            Console.WriteLine("6. Ispis Fibonaccijevog niza");
            Console.WriteLine("7. Preokret stringa");
            Console.WriteLine("8. Brojanje samoglasnika");
            Console.WriteLine("9. Pretvorba temperature");
            Console.WriteLine("10. Sortiranje niza");
            Console.WriteLine("11. Kalkulator");


            /*
    11. Kalkulator:
        Napiši program koji od korisnika traži da unese dva broja i operaciju (+, -, *, /), a zatim izračunava i ispisuje rezultat. Koristi switch statement za odabir operacije.

 */




            Console.WriteLine("\n******************************************");
            OcitajOdabir();
        }

        private void OcitajOdabir()
        {
            int odabir = Pomocno.UcitajCijeliBroj("Unesi redni broj programa");
            switch (odabir)
            {
                case 0:
                    Console.WriteLine("Dovidenja!");
                    break;
                case 1:
                    Zad1.Izvedi();
                    break;
                case 2:
                    Zad2.Izvedi();
                    break;
                case 3:
                    Zad3.Izvedi();
                    break;
                case 4:
                    Zad4.Izvedi();
                    break;
                case 5:
                    Zad5.Izvedi();
                    break;
                case 6:
                    Zad6.Izvedi();
                    break;
                case 7:
                    Zad7.Izvedi();
                    break;
                case 8:
                    Zad8.Izvedi();
                    break;
                case 9:
                    Zad9.Izvedi();
                    break;
                case 10:
                    Zad10.Izvedi();
                    break;
                case 11:
                    Zad11.Izvedi();
                    break;
                default:
                    Console.WriteLine("Ne postoji taj program");
                    break;
            }

            if (odabir != 0)
            {
                Izbornik();
            }
        }
    }
}

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
        public Program()
        {
            Zad1 = new Zadatak1();
            Zad2 = new Zadatak2();
            Zad3 = new Zadatak3();
            Zad4 = new Zadatak4();
            Zad5 = new Zadatak5();
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


            /*
    6. Ispis Fibonaccijevog niza:
        Napiši program koji od korisnika traži da unese broj n, a zatim ispisuje prvih n brojeva Fibonaccijevog niza (0, 1, 1, 2, 3, 5, 8...).
    7. Preokret stringa:
        Napiši program koji od korisnika traži da unese string, a zatim ispisuje taj string naopako (npr. "zdravo" postaje "ovardz").
    8. Brojanje samoglasnika:
        Napiši program koji od korisnika traži da unese string, a zatim prebrojava i ispisuje koliko samoglasnika ima u tom stringu.
    9. Pretvorba temperature:
        Napiši program koji od korisnika traži da unese temperaturu u Celzijusima i pretvara je u Fahrenheit (°F = °C * 9/5 + 32) ili obrnuto, ovisno o odabiru korisnika.
    10. Sortiranje niza:
        Napiši program koji deklarira niz cijelih brojeva, traži od korisnika da unese vrijednosti u niz, a zatim sortira niz uzlazno i ispisuje sortirani niz.
    11. Kalkulator:
        Napiši program koji od korisnika traži da unese dva broja i operaciju (+, -, *, /), a zatim izračunava i ispisuje rezultat. Koristi switch statement za odabir operacije.

 */




            Console.WriteLine("\n****************************************");
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
                    //Console.WriteLine("1.Zadatak");
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
                    default:
                    Console.WriteLine("Ne postoji taj program");
                    break;
            }

            if (odabir != 0)
            {
                Izbornik();
            }



            //switch (Pomocno.UcitajCijeliBroj("Unesi redni broj programa"))
            //{
            //    case 0:
            //        Console.WriteLine("Dovidenja!");
            //        break;
            //    case 1:
            //        Console.WriteLine("1.Zadatak");
            //        Izbornik();
            //        break;
            //    default:
            //        Console.WriteLine("Ne postoji taj program");
            //        Izbornik();
            //        break;
            //}
        }
    }
}

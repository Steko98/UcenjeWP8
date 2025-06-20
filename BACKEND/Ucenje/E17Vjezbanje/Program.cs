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
        public Program()
        {
            Zad1 = new Zadatak1();
            Izbornik();
        }

        private void Izbornik()
        {
            Console.WriteLine("\n****************************************");
            Console.WriteLine("*****************IZBORNIK*****************");
            Console.WriteLine("0. Izlaz");
            Console.WriteLine("1. Zbrajanje dvaju brojeva");
            Console.WriteLine("****************************************");
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

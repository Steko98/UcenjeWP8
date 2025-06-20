using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Authentication.ExtendedProtection;
using System.Text;
using System.Threading.Tasks;

namespace Ucenje.E15Nasljedivanje
{
    public class Program
    {
        public Program()
        {
            Console.WriteLine("Nasljedivanje");

            var oso = new Osoba() { Ime = "Marija", Prezime = "Kaz" };

            Predavac pre = new() { Ime = "Karlo", Prezime = "Lot", IBAN = "HR28475928476493" };

            Polaznik pol = new Polaznik() { Ime = "Karla", Prezime = "Sep", Telefon = "099/325-636" };

            Polaznik pol1 = new Polaznik() { Ime = "Karla", Prezime = "Sep", Telefon = "099/325-636" };

            Console.WriteLine(pol.Equals(pol1));
            Console.WriteLine(pol.GetHashCode());
            Console.WriteLine(pol1.GetHashCode());
            Console.WriteLine(pol.ToString());

            Console.WriteLine(pol);
            Console.WriteLine(pre.ToString);
        }
    }
}

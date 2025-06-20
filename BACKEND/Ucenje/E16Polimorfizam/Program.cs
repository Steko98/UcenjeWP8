using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Ucenje.E16Polimorfizam
{
    public class Program
    {
        public Program()
        {
            Console.WriteLine("Polimorfizam");

            Osoba[] osobe = new Osoba[5];

            osobe[0] = new Polaznik() { Ime = "Pero", Telefon = "283" };
            osobe[1] = new Predavac() { Ime = "Karla", IBAN = "3524344533" };
            osobe[2] = new Predavac() { Ime = "Lota", IBAN = "HR44533" };
            osobe[3] = new Polaznik() { Ime = "Ivana", Telefon = "0912313534" };
            osobe[4] = new Predavac() { Ime = "Josip", IBAN = "HR32524235" };



            Ispisi(osobe);


            var p = new Polaznik();
            p.Log("Problem kod prijave");


            var r = new Ravnatelj();
            r.Log("Ravnatelj je izuzet");
        }

        public static void Ispisi(Osoba[] osobe)
        {
            foreach (Osoba o in osobe)
            {
                Console.WriteLine(o.Pozdravi());
            }
        }
    }
}

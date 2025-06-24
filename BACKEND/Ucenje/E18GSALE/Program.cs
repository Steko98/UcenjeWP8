using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Ucenje.E18GSALE

using System.Security.Cryptography;

namespace Ucenje.E18GSALE
{
    public class Program
    {

        public Program()
        {
            Console.WriteLine("GSALE");


            var o = new Obrada<string>();

            o.PredmetObrade = "Osijek";
            //o.PredmetObrade = 67; // greška je predmet obrade može biti samo string (<string>)
            o.Posao();


            var obrada = new Obrada<int>();
            obrada.PredmetObrade = 67;
            //obrada.PredmetObrade = "Osijek"; // greška je predmet obrade može biti samo int (<int>)
            obrada.Posao();


            // rad s listama
            var lista = new List<string>();
            string[] gradovi = new string[10];

            lista.Add("Osijek");
            lista.Add("Zagreb");

            Console.WriteLine(lista[0]); // Osijek
            Console.WriteLine("*************************");
            foreach (string s in lista)
            {
                Console.WriteLine(s);
            }

            var brojevi = new List<int>() { 2, 34, 4, 5, 6, 6, 4 };

            brojevi.Add(3);

            foreach (int i in brojevi)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine(brojevi.Count);

            brojevi.RemoveAt(1);

            Console.WriteLine(brojevi.Count);

            Console.WriteLine(brojevi);

            Console.WriteLine("************************");

            // var eo = new EdunovaObrada<string>(); // Greška jer string ne nasljeđuje Entitet
            var os = new Obrada<Smjer>(); // Smjer nasljeđuje Object

            string ime = "sss";

            var eo = new EdunovaObrada<Smjer>();

            eo.Entitet = new Smjer() { Sifra = 1, Naziv = "WP" };
            eo.OdradiPosao();

            var op = new EdunovaObrada<Polaznik>();
            op.Entitet = new Polaznik() { Sifra = 10, Ime = "Pero" };
            op.OdradiPosao();

            var lo = new Obrada<List<Smjer>>();

            var smjerovi = new List<Smjer>();

            smjerovi.Add(new Smjer() { Naziv = "Web programiranje" });
            smjerovi.Add(new Smjer() { Naziv = "Računovodstvo" });

            smjerovi.Sort(); // metoda sort zove metodu CompareTo


            foreach (var s in smjerovi)
            {
                Console.WriteLine(s);
            }

            // 6. način iteracije: funkcionalno programiranje
            smjerovi.ForEach(s => Console.WriteLine(s)); // => lambda izraz


            Console.WriteLine(Zbroji(2, 3));

            // kreiranje "interne" metode s pomoću lambda izraza
            // nalazimo se unutar konstruktora
            var Zbroj = (int i, int j) => i + j;


            Console.WriteLine(Zbroj(2, 3));


            var algoritam = (int x, int y) =>
            {
                var k = 2;
                k += x;
                y = --y + k;
                return k + x + y;

            };

            Console.WriteLine(algoritam(1, 2));



            smjerovi.Sort((s1, s2) =>
            {
                return s1.Naziv.CompareTo(s2.Naziv);
            });


            smjerovi[0].Naziv.EdunovaProvjera();
            o.PredmetObrade.EdunovaProvjera();

            int r = smjerovi[0].Broj();


            Console.WriteLine("{0}, {1}", r, eo.Broj());




        } // kraj konstruktora


        private int Zbroji(int i, int j)
        {
            return i + j;
        }


    }
}

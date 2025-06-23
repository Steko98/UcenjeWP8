using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ucenje.E17Vjezbanje
{
    public class Zadatak8
    {
        private int brojIzvodenja = 0;

        public void Izvedi()
        {
            brojIzvodenja++;

            string tekst = Pomocno.UcitajString("Unesite tekst");
            tekst = tekst.ToLower();
            string samoglasnici = "aeiou";
            int brojSamoglasnika = 0;

            for (int i = 0; i < tekst.Length; i++)
            {
                for (int j = 0; j < samoglasnici.Length; j++)
                {
                    if (tekst[i] == samoglasnici[j])
                    {
                        brojSamoglasnika++;
                    }
                }
            }
            Console.WriteLine("Zadani stringu sadrži {0} samoglasnik/a", brojSamoglasnika);
            Console.WriteLine("Završio {0}. izvodenje", brojIzvodenja);
        }
    }
}

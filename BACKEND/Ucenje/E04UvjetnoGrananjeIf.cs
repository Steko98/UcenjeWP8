using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ucenje
{
    class E04UvjetnoGrananjeIf
    {
        public static void Izvedi()
        {
            Console.WriteLine("E04UvjetnoGrananjeIf");

            int broj = 7;

            bool uvjet = broj == 7;

            if (uvjet)
            {
                Console.WriteLine("Super");
            }

            if (broj > 2)
            {
                Console.WriteLine("ok");
            }
            else if (broj == 1)
            {
                Console.WriteLine("Nije dobro");
            }
            else
            {
                Console.WriteLine("Nije ocjena");
            }

            int i = 5, j = 10;

            if(i>10 & j> 2){
                Console.WriteLine("Nece se ispisati");
            }

            if (i > 10 && j > 2)
            {
                Console.WriteLine("Nece se ispisati");
            }

            if(i==4 || j == 2)
            {
                Console.WriteLine("Jedno od dvoje");
            }

            if (!uvjet)
            {
                Console.WriteLine("Kada gore ne ispise, ovdje ce");
            }



            string grad = "Osijek";
            if(uvjet && i > 10)
            {
                if(grad == "Vukovar")
                {
                    Console.WriteLine("Novi prvoligas");
                }
            }

            if (grad == "Osijek")
            {
                Console.WriteLine("Super");
            } else
            {
                Console.WriteLine("ok");
            }

            Console.WriteLine(grad=="Osijek" ? "Super" : "OK");













        }
    }
}

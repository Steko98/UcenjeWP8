﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Subota1
{
    internal class S02Kvadratura
    {
        public static void Izvedi()
        {
            Console.WriteLine("Kvadratura.com");
            Console.Write("Unesite duljinu prostorije u metrima: ");
            double duljinaProstorije = double.Parse(Console.ReadLine());
            Console.Write("Unesite širinu prostorije u metrima: ");
            double sirinaProstorije = double.Parse(Console.ReadLine());
            double kvadratura = duljinaProstorije * sirinaProstorije;
            Console.WriteLine("Prostorija ima {0} kvadrata", kvadratura);
        }
    }
}

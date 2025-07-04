﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ucenje.ZavrsniRad
{
    public class Pomocno
    {
        //************************************** UcitajString *********************************************************************
        /// <summary>
        /// Učitava i vraća string koji korisnik unese putem konzole.
        /// Ponovno traži unos dok korisnik ne unese ne-prazan string.
        /// </summary>
        /// <param name="poruka">Poruka koja se prikazuje korisniku prije unosa.</param>
        /// <returns>Uneseni string.</returns>
        public static string UcitajString(string poruka)
        {
            string s;
            for (; ; )
            {
                Console.Write(poruka + ": ");
                s = Console.ReadLine().Trim();
                if (s.Length > 0)
                {
                    return s;
                }
                Console.WriteLine("Obavezan unos!");
            }
        }
        //**************************************** Ucitaj Cijeli Broj *************************************************************
        /// <summary>
        /// Učitava cijeli broj koji korisnik unese putem konzole.
        /// Ponovno traži unos dok korisnik ne unese ispravan cijeli broj.
        /// </summary>
        /// <param name="poruka">Poruka koja se prikazuje korisniku prije unosa.</param>
        /// <returns>Uneseni cijeli broj.</returns>
        public static int UcitajCijeliBroj(string poruka)
        {
            while (true)
            {
                Console.Write(poruka + ": ");
                try
                {
                    return int.Parse(Console.ReadLine());
                }
                catch
                {
                    Console.WriteLine("Potrebno je unijeti broj znamenkom. Pokušajte ponovno.");
                }
            }
        }
        //**************************************** Ucitaj Bool *************************************************************
        /// <summary>
        /// Učitava i vraća bool vrijednost na temelju korisničkog unosa.
        /// Korisniku se prikazuje poruka s opcijama '1 za DA' ili '2 za NE'.
        /// Ponovno traži unos dok korisnik ne unese ispravan broj (1 ili 2).
        /// </summary>
        /// <param name="poruka">Poruka koja se prikazuje korisniku prije unosa.</param>
        /// <returns>True ako korisnik unese 1 (DA), false ako unese 2 (NE).</returns>
        public static bool UcitajBool(string poruka)
        {
            while (true)
            {
                Console.Write(poruka + " (1 za DA ili 2 za NE): ");
                int odabir = 0;

                for (; ; )
                {
                    try
                    {
                        odabir = int.Parse(Console.ReadLine());
                        break;
                    }
                    catch
                    {
                        Console.WriteLine("Nevažeći unos. Pokušajte ponovno.");
                    }
                }
                if (odabir == 1)
                {
                    return true;
                }
                else if (odabir == 2)
                {
                    return false;
                }
                else
                {
                    Console.Write("Nevažeći unos. Molimo unesite '1' za DA ili '2' za NE. Pokušajte ponovo: ");
                    odabir = int.Parse(Console.ReadLine());
                }
            }
        }
        //********************************************** Ucitaj Raspon *****************************************************************
        /// <summary>
        /// Učitava cijeli broj unutar zadanog raspona koji korisnik unese putem konzole.
        /// Ponovno traži unos dok korisnik ne unese ispravan cijeli broj unutar zadanih granica.
        /// </summary>
        /// <param name="poruka">Poruka koja se prikazuje korisniku prije unosa.</param>
        /// <param name="min">Minimalna dozvoljena vrijednost (uključivo).</param>
        /// <param name="max">Maksimalna dozvoljena vrijednost (uključivo).</param>
        /// <returns>Uneseni cijeli broj unutar zadanog raspona.</returns>
        internal static int UcitajRasponBroja(string poruka, int min, int max)
        {
            int b;
            while (true)
            {
                try
                {
                    Console.Write(poruka + ": ");
                    b = int.Parse(Console.ReadLine());
                    if (b < min || b > max)
                    {
                        throw new Exception();
                    }
                    return b;
                }
                catch
                {
                    Console.WriteLine("Unos mora biti u rasponu {0} do {1}", min, max);
                }
            }
        }
        //********************************************* Ucitaj Datum ******************************************************************
        /// <summary>
        /// Učitava i vraća datum koji korisnik unese putem konzole.
        /// Korisniku se prikazuje poruka s formatom unosa "yyyy-MM-dd".
        /// Ponovno traži unos dok korisnik ne unese ispravan datum u traženom formatu.
        /// </summary>
        /// <param name="poruka">Poruka koja se prikazuje korisniku prije unosa.</param>
        /// <returns>Uneseni datum tipa DateTime.</returns>
        public static DateTime UcitajDatum(string poruka)
        {
            DateTime datum;

            while (true)
            {
                try
                {
                    Console.WriteLine("Format unosa je yyyy-MM-dd");
                    Console.Write(poruka + ": ");
                    datum = DateTime.Parse(Console.ReadLine());
                    return datum;
                }
                catch
                {
                    Console.WriteLine("Nepravilan nos datuma");
                }
            }
        }
        //***************************************************************************************************************
    }
}

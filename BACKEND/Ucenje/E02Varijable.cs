namespace Ucenje
{
    class E02Varijable
    {
        public static void Izvedi()
        {
            //deklaracija varijable
            //tip podataka i ime
            string ime;


            Console.Write("Unesi svoje ime: ");
            // dodijeljivanje vrijednosti varijabli
            ime = Console.ReadLine();

            //ispisivanje sadrzaja varijable
            Console.WriteLine(ime);

            Console.WriteLine(ime[0]);

            char znak = '@';
            Console.WriteLine(znak);

            Console.WriteLine((int)znak);

            int cijeliBroj = int.MaxValue;

            Console.WriteLine(int.MaxValue);
            Console.WriteLine(cijeliBroj + 1);

            Console.Write("Unesi broj cipela: ");
            int brojCipela = int.Parse(Console.ReadLine());
            Console.WriteLine(brojCipela + 1);

            bool logickiTip = true;

            float decimalniBroj = 3.14f;

            double velikiDecimalniBroj = 3.14;

            decimal decimalniBr = 3.14m;




            //kraj metode
        }
    }
}

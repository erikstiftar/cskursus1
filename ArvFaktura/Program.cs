using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArvFaktura
{
    class Program
    {
        static void Main(string[] args)
        {

            Faktura f = new Faktura() { Nr = 123, Dato = DateTime.Now.Date, Kunde = "Jens" };
            Console.WriteLine(f);

            Hund h = new Hund() { Navn = "Fido" };
            h.SigNoget();
            Kat k = new Kat() { Navn = "Dofi" };
            k.SigNoget();

            List<Dyr> forskelligeDyr = new List<Dyr>() { h, k, new Hund() { Navn = "c" }, new Kat() { Navn = "d" } };

            foreach (Dyr item in forskelligeDyr)
            {
                item.SigNoget();
            }

            Console.WriteLine();
            Dyr[] dyr = new Dyr[20];

            for (int i = 0; i < 20; i++)
            {
                dyr[i] = Dyr.TilfældigtDyr();
            }

            foreach (var item in dyr)
            {
                item.SigNoget();
            }

            if (System.Diagnostics.Debugger.IsAttached)
            {
                Console.Write("Press any key to continue . . . ");
                Console.ReadKey();
            }
        }
    }

    class Faktura
    {
        public int Nr { get; set; }
        public DateTime Dato { get; set; }
        public string Kunde { get; set; }

        public override string ToString()
        {
            return $"Faktura til {Kunde} nr {Nr} fra {Dato:D}.";
        }

    }

    abstract class Dyr
    {
        public string Navn { get; set; }

        public virtual void SigNoget()
        {
            Console.WriteLine($"Jeg er et dyr og hedder {Navn}.");
        }

        private static System.Random rnd = new Random();

        public static Dyr TilfældigtDyr()
        {

            string data = "Freja;Bella;Emma;Mille;Fie;Molly;Lady;Trine;Trunte;Luna;Amanda;";
            data += "Bonnie;Laika;Ronja;Sally;Trille;Zita;Tøsen;Bianca;Zenta;Victor;Buller;";
            data += "Buster;King;Simba;Thor;Charlie;Samson;Bamse;Mickey;Max;Rasmus;Sofus;Anton;";
            data += "Laban;Basse;Bølle;Oliver;Oscar;Balder";
            string[] navne = data.Split(';');
            int index = rnd.Next(0, navne.Length);
            if (index % 2 == 0)
            {
                return new Hund() { Navn = navne[index] };
            }
            else
            {
                return new Kat() { Navn = navne[index] };
            }
        }
    }

    class Hund : Dyr
    {
        public override void SigNoget()
        {
            Console.WriteLine($"Jeg er en hund og hedder {Navn}.");
        }
    }

    class Kat : Dyr
    {
        public override void SigNoget()
        {
            Console.WriteLine($"Jeg er en kat og hedder {Navn}.");
        }
    }

}

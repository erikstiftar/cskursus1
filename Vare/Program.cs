using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vare
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //Console.WriteLine("Indtast vare navn:");
            //string navn = Console.ReadLine();
            //Console.WriteLine("Indtast vare pris:");
            //double pris = Convert.ToDouble(Console.ReadLine());

            //Vare vare_1 = new Vare(navn,pris);

            //Console.WriteLine("Varens navn: " + vare_1.Navn);
            //Console.WriteLine("Varens pris: " + vare_1.Pris);
            //Console.WriteLine("Varens pris med moms: " + vare_1.PrisMedMoms());

            Console.WriteLine("Indtast fornavn:");
            string fnavn = Console.ReadLine();
            Console.WriteLine("Indtast efternavn:");
            string enavn = Console.ReadLine();

            Person p = new Person();
            p.Fornavn = fnavn;
            p.Efternavn = enavn;

            Console.WriteLine("Fuldt navn: " + p.FuldtNavn());

            if (System.Diagnostics.Debugger.IsAttached)
            {
                Console.Write("Press any key to continue . . . ");
                Console.ReadKey();
            }
        }
    }

    public class Vare
    {
        public static double Moms = 0.25;

        public Vare()
        {
            Navn = "";
            Pris = 0;
        }

        public Vare(string navn, double pris)
        {
            Navn = navn;
            Pris = pris;
        }

        private string _navn;

        public string Navn
        {
            get { return _navn; }
            set { _navn = value; }
        }
        private double _pris;

        public double Pris
        {
            get { return _pris; }
            set { _pris = value; }
        }

        public double PrisMedMoms()
        {
            return Pris + (Pris * Moms);
        }

    }

    public class Person
    {
        public string Fornavn { get; set; }

        private string _efternavn;

        public string Efternavn
        {
            get { return _efternavn; }
            set
            {
                if (value.Length > 3)
                  _efternavn = value;
                else
                  _efternavn = "";  
            }
        }

        public string FuldtNavn()
        {
            return Fornavn + " " + Efternavn;
        }
    }
}

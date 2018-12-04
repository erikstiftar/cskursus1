using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP1
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Person p1 = new Person();
            Person p2 = new Person("Jens", "Jensen");
            Person p3 = new Person("Peter", "Petersen", 1990);

            p1.Fornavn   = "Mads";
            p1.Efternavn = "Madsen";

            p1.Fødselsår = 2010;
            p2.Fødselsår = 2000;

            Console.WriteLine(p1.FuldtNavn() + " " + p1.Alder());
            Console.WriteLine(p2.FuldtNavn() + " " + p2.Alder());
            Console.WriteLine(p3.FuldtNavn() + " " + p3.Alder());

            if (System.Diagnostics.Debugger.IsAttached)
            {
                Console.Write("Press any key to continue . . . ");
                Console.ReadKey();
            }
        }
    }

    internal class Person
    {
        public string Fornavn;
        public string Efternavn;
        public int Fødselsår;

        public Person()
        {
            Fornavn   = "";
            Efternavn = "";
        }

        public Person(string f, string e)
        {
            Fornavn   = f;
            Efternavn = e;
        }

        public Person(string f, string e, int a) : this(f, e)
        {
            Fødselsår = a;
        }

        public string FuldtNavn()
        {
            return Fornavn + " " + Efternavn;
        }

        public int Alder()
        {
            return DateTime.Now.Year - Fødselsår;
        }
    }
}

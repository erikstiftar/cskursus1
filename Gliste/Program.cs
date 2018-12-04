using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gliste
{
    public class Program
    {
        public static void Main(string[] args)
        {
            List<Person> lp = new List<Person>();
            lp.Add(new Person(1, "Jens"));
            lp.Add(new Person(2, "Mads"));
            lp.Add(new Person(3, "Hans"));

            foreach(var item in lp)
            {
                Console.WriteLine($"{item.Id} {item.Navn}");
            }

            Dictionary<int, Person> dp = new Dictionary<int,Person>();
            dp.Add(101, lp[0]);
            dp.Add(102, lp[1]);
            dp.Add(103, lp[2]);

            Console.WriteLine($"{dp[102].Id} {dp[102].Navn}");
            //Console.WriteLine($"{dp.Where(i=> i.Key == 102)}"); ???

            Bunke b = new Bunke();
            b.TilføjKort(new Kort() { Kulør = "Spar", Værdi = 2 });
            b.TilføjKort(new Kort() { Kulør = "Hjerter", Værdi = 14 });
            b.TilføjKort(new Kort() { Kulør = "Ruder", Værdi = 3 });

            b.Vis();
            var k = b.FjernKort();
            Console.WriteLine("Fjernet: " + k);
            b.Vis();

            if (System.Diagnostics.Debugger.IsAttached)
            {
                Console.Write("Press any key to continue . . . ");
                Console.ReadKey();
            }
        }
    }

    public class Person
    {
        public int Id { get; set; }
        public string Navn { get; set; }

        public Person()
        {
        }

        public Person(int id, string navn)
        {
            Id = id;
            Navn = navn;
        }
    }

    public class Kort
    {
        public string Kulør { get; set; }
        public int Værdi { get; set; }
        public override string ToString()
        {
            return Kulør + " " + Værdi;
        }
    }

    public class Bunke
    {
        private Stack<Kort> _kortstack = new Stack<Kort>();

        public void TilføjKort(Kort kort)
        {
            _kortstack.Push(kort);
        }

        public Kort FjernKort()
        {
            return _kortstack.Pop();
        }

        public void Vis()
        {
            foreach (var item in _kortstack)
            {
                Console.WriteLine($"{item.ToString()}");
            }
        }
    }

}

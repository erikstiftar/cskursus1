using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var r = new PersonNuGetPackage.PersonRepositoryRandom();

            var people = r.GetPeople(10);
            foreach (var person in people)
                Console.WriteLine(person.Name);
            Console.WriteLine();

            var res1 = people.OrderBy(i => i.Name);
            foreach (var person in res1)
                Console.WriteLine(person.Name);
            Console.WriteLine();

            var res2 = people.OrderBy(i => i.Gender).ThenBy(i => i.Name);
            foreach (var person in res2)
                Console.WriteLine(person.Gender + " " + person.Name);
            Console.WriteLine();

            var res3 = people.Where(i => i.Height < 170);
            foreach (var person in res3)
                Console.WriteLine(person.Height + " " + person.Name);
            Console.WriteLine();

            var res4 = people.Where(i => i.Height < 170 && i.IsHealthy);
            foreach (var person in res4)
                Console.WriteLine(person.Height + " " + person.IsHealthy + " " + person.Name);
            Console.WriteLine();

            var res5 = people.GroupBy(i => i.Gender);
            foreach (var gruppe in res5)
            {
                Console.WriteLine(gruppe.Key);
                foreach (var person in gruppe)
                {
                    Console.WriteLine("  " + person.Name);
                }
            }
            Console.WriteLine();

            var res6 = people.OrderBy(i => i.Name).Select(i => new { Name = i.Name, Height = i.Height });
            foreach (var person in res6)
                Console.WriteLine(person.Height + " " + person.Name);
            Console.WriteLine();

            int[] range = { 160, 170, 180, 190, 200, 210, 220 };
            var res7 = people.OrderBy(i => i.Height).GroupBy(i => range.FirstOrDefault(x => x > i.Height));
            foreach (var gruppe in res7)
            {
                Console.WriteLine(gruppe.Key);
                foreach (var person in gruppe)
                {
                    Console.WriteLine("  " + person.Name + " " + person.Height);
                }
            }
            Console.WriteLine();

            if (System.Diagnostics.Debugger.IsAttached)
            {
                Console.Write("Press any key to continue . . . ");
                Console.ReadKey();
            }
        }
    }
}

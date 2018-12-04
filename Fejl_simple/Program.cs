using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fejl_simple
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            for (int antal = 1, max_antal = 3; antal <= max_antal; antal++ )
            
            {
                try
                {
                    Run();
                    antal += max_antal;
                }
                catch (Exception e)
                {
                    Console.WriteLine("Der er sket en fejl – " + e.Message);
                    if (antal < max_antal)
                    {
                        Console.WriteLine("Prøv igen.");
                    }
                }
            }

            if (System.Diagnostics.Debugger.IsAttached)
            {
                Console.Write("Press any key to continue . . . ");
                Console.ReadKey();
            }
        }

        private static void Run()
        {
            Console.WriteLine("Indtast 1. tal");
            int tal1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Indtast 2. tal");
            int tal2 = Convert.ToInt32(Console.ReadLine());
            int res = tal1 + tal2;
            Console.WriteLine("resultatet er " + res);
        }
    }

}

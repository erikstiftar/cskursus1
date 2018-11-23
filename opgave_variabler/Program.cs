using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace opgave_variabler
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 10;
            i++;
            i--;
            i += 20;
            Console.WriteLine(i);

            double d = 12.5;
            d++;
            d--;
            d *= 2;
            Console.WriteLine(d);

            if (System.Diagnostics.Debugger.IsAttached)
            {
                Console.Write("Press any key to continue . . . ");
                Console.ReadKey();
            }
        }
    }
}

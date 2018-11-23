using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace enum_struct
{
    class Program
    {
        static void Main(string[] args)
        {
            FilTyper ft = FilTyper.csv;
            Console.WriteLine(ft);
            Console.WriteLine((int)ft);

            Person p = new Person();
            p.Id = 1;
            p.Navn = "Mikkel";
            p.Køn = Køn.Kvinde;
            Console.WriteLine(p.Navn);

            if (System.Diagnostics.Debugger.IsAttached)
            {
                Console.Write("Press any key to continue . . . ");
                Console.ReadKey();
            }
        }
    }
}

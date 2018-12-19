using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventApp
{
    class Program
    {
        static void Main(string[] args)
        {
            System.IO.FileSystemWatcher w = new System.IO.FileSystemWatcher(@"c:\temp", "Test*.txt");
            w.EnableRaisingEvents = true;
            // bind en metode til w.Changed

            w.Created += (s, e) => {
                Console.WriteLine("oprettet " +e.Name);
            };
            w.Renamed += (s, e) => {
                Console.WriteLine("omdøbt  " + e.Name);
            };
            w.Deleted += (s, e) => {
                Console.WriteLine("slettet " + e.Name);
            };

            do
            {

            } while (true);

            if (System.Diagnostics.Debugger.IsAttached)
            {
                Console.Write("Press any key to continue . . . ");
                Console.ReadKey();
            }
        }
    }
}

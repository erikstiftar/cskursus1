using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace text_variabler
{
    class Program
    {
        static void Main(string[] args)
        {
            string f = "Mikkel";
            string e = "Cronberg";
            string samletNavn = f + " " + e;
            string navnStort  = samletNavn.ToUpper();
            string navnLille  = samletNavn.ToLower();
            string navnDel    = samletNavn.Substring(7,4);

            Console.WriteLine(f);
            Console.WriteLine(e);
            Console.WriteLine(samletNavn);
            Console.WriteLine(navnStort);
            Console.WriteLine(navnLille);
            Console.WriteLine(navnDel);

            Console.WriteLine("\t" + samletNavn + "\r\n\t" + samletNavn);

            System.IO.File.WriteAllText(@"C:\source\cskursus\Test text.txt", "\t" + samletNavn + "\r\n\t" + samletNavn);
            Console.WriteLine("Fil er oprettet.");

            if (System.Diagnostics.Debugger.IsAttached)
            {
                Console.Write("Press any key to continue . . . ");
                Console.ReadKey();
            }
        }
    }
}

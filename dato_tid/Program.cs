using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dato_tid
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime d1 = DateTime.Now;
            Console.WriteLine(d1);
            d1 = d1.AddDays(10);
            Console.WriteLine(d1);
            d1 = d1.AddMinutes(20);
            Console.WriteLine(d1);
            d1 = d1.AddMonths(-1);
            Console.WriteLine(d1);

            Console.WriteLine(DateTime.Now.AddDays(10).AddMinutes(20).AddMonths(-1));

            if (d1 != DateTime.Now)
            {
                Console.WriteLine(d1.ToString("yyyyMMdd  "));
                Console.WriteLine(d1.ToString("yyyy-MM-dd-hh.mm.ss.ffffff"));
                Console.WriteLine(DateTime.IsLeapYear(d1.Year));
            }

            DateTime d2 = DateTime.Now;
            DateTime d3 = new DateTime(2018,12,24);
            TimeSpan t1 = d3 - d2;
            Console.WriteLine(t1.Days);

            TimeSpan t2 = new TimeSpan(16, 00, 00);
            Console.WriteLine(t2);
            TimeSpan t3 = new TimeSpan(00, 30, 00);
            Console.WriteLine(t3);
            TimeSpan t4 = t2 - t3;
            Console.WriteLine(t4.ToString());
            TimeSpan t5 = t2 + t3;
            Console.WriteLine(t5.ToString());

            if (System.Diagnostics.Debugger.IsAttached)
            {
                Console.Write("Press any key to continue . . . ");
                Console.ReadKey();
            }
        }
    }
}

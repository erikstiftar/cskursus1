using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metoder
{
    class Program
    {
        static void Main(string[] args)
        {
            Test1();
            Test2();
            Test3(1, 1);
            Test4(1, 1);
            int res = Test4(2, 2);
            Console.WriteLine(res);

            int x = 100;
            Test4(x, 2);
            Console.WriteLine(x);

            Metode1("", 1, true, "dk");
            Metode1(navn: "", alder: 1, erSmart:  true, land: "dk");
            Metode1(navn: "", erSmart: true, land: "dk" , alder: 1 );

            MinReturType res2 = Test10();
            Console.WriteLine(res2.a);

            (int, bool) res3 = Test11();
            Console.WriteLine(res3.Item1);

            (int a, bool b) res4 = Test12();
            Console.WriteLine(res4.a);

            var res5 = Test12();
            Console.WriteLine(res5.a);

            int i = 10;

            SkrivFiler(@"c:\temp");
        }


        public static void SkrivFiler(string sti) {
            var filer = System.IO.Directory.GetFiles(sti);
            foreach (var fil in filer)
                Console.WriteLine(fil);
            var mapper = System.IO.Directory.GetDirectories(sti);
            foreach (var mappe in mapper)
                SkrivFiler(mappe);
        }


        public static (int a, bool b) Test12()
        {
            return (4, true);
        }


        public static (int, bool) Test11()
        {
            return (4, true);
        }


        static MinReturType Test10() {
            MinReturType t = new MinReturType();
            t.a = 10;
            t.b = true;
            return t;
        }


        static void Skriv() {
            Skriv(1, 1);
        }
        static void Skriv(int a) {
            Skriv(a, 1);
        }
        static void Skriv(int a, int b) {

            // log
            // sikkerhed
            // validering

            // Kode..
        }


        static void Test1() {
            Console.WriteLine("I test1");
        }

        static void Test2()
        {
            // kode
            if(true)
                return;
            Console.WriteLine("I test1");
        }
        static void Test3(int a, int b)
        {
            Console.WriteLine(a + b);
            Console.WriteLine("I test3");
        }

        static int Test4(int a, int b)
        {
            a = 10;
            Console.WriteLine("I test4");
            return a + b;
        }

        static void Test5() {
            Test();

            void Test() { }
            void Test2() { }
            void Test3() { }

        }

        static void Metode1(string navn, int alder, bool erSmart, string land)
        {
        }
    }

    struct MinReturType {
        public int a;
        public bool b;
    }
}

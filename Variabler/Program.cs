using System;

namespace Variabler
{
    class Program
    {
        static void Main(string[] args)
        {

            //int numberMonths;
            //byte r = 300;

            {
                int a = 10;

                Console.WriteLine(a.ToString());
                Console.WriteLine(int.MinValue);
                if (a < int.MinValue) { }


                int aa = 10;

                double d = 234234.8484848;
                //float f = System.Convert.ToDouble(2334.344;


                int e = 1;
                e = e + 1;
                e++;
                e += 10;





                bool tt = false;

                if (tt == true) { }

                Console.WriteLine("xdxffx");

                int w = 100, v = 30, r = v + w;
                Console.WriteLine(w);

                Console.WriteLine("Tal " + w);
                string ds = "";
                //for (int i = 0; i < 1000000; i++)
                //{
                //    ds = ds + "*";
                //}

                string navn = "dkjsd lrj æfdk hdflkjhg ælkfdjhg h";
                Console.WriteLine($"Tal {w + v} er for stort");



            }


            {

                DateTime a;
                a = DateTime.Now;
                Console.WriteLine(a);

                DateTime b = new DateTime(2018, 12, 24);
                Console.WriteLine(b);

                DateTime c = b.AddDays(10);

                DateTime d = new DateTime(2018, 12, 1);
                DateTime e = d.AddMonths(1).AddDays(-1);
                Console.WriteLine(e);

                TimeSpan ts = b - d;
                Console.WriteLine(ts.TotalMinutes);
                TimeSpan ts2 = b.Subtract(d);

            }


            {
                checked
                {
                    byte b = 255;
                    Console.WriteLine($"b={b}");
                    //b++;
                    //b++;
                    Console.WriteLine($"b={b}");
                }
            }

            {


                char tegn = 'k';
                string navn1 = "mikkel";
                string navn2 = "mathias";
                Console.WriteLine(navn1);
                Console.WriteLine(navn1 + navn2);
                if (navn1 == navn2) { } else { }


                //string sti = "c:\temp\test.txt";
                //string sti = "c:\\temp\\test.txt";
                string sti = @"c:\temp\test.txt";
                Console.WriteLine(sti);


            }

            {

                // Stopur
                System.Diagnostics.Stopwatch s = new System.Diagnostics.Stopwatch();
                s.Start();
                string a = "";
                for (int i = 0; i < 5000; i++)
                {
                    a = a + "*";
                }
                s.Stop();
                Console.WriteLine($"ms = {s.ElapsedMilliseconds}");
            }


            {

                // Stopur
                System.Diagnostics.Stopwatch s = new System.Diagnostics.Stopwatch();
                System.Text.StringBuilder sb = new System.Text.StringBuilder();
                s.Start();
                for (int i = 0; i < 10000000; i++)
                {
                    sb.Append("*");
                }
                s.Stop();
                Console.WriteLine($"ms = {s.ElapsedMilliseconds}");
            }

            {
                string a = null;
                if (a == null)
                    Console.WriteLine("");
                else
                    Console.WriteLine(a.ToUpper());

                Console.WriteLine(a?.ToUpper());

            }
            {
                double reeltTal2 = 4049586049860498604986049860498604958604865030.75;
                //int lilleHeltal2 = (int)reeltTal2;
                //int lilleHeltal2 = System.Convert.ToInt32(reeltTal2);

                string dato = "2018-12-24";
                DateTime d = Convert.ToDateTime(dato);

            }


            {

                var y = 12;

                int s = 10;
                var ss = 2843;



                int[] f = new int[] { 4, 3, 1, 6, 4, 3, 2, 6 }; // int[]
                //var g = f.GroupBy(i => i);          // IGrouping<int, int>
                //foreach (var item in g)
                //{
                //    item.ke
                //}


            }

            {

                bool? k = null;

                if (k.HasValue) { } else { }

                const int antalMåneder = 12;




            }

            {

                //string navn1 = "mikkel";
                //int alder1 = 15;
                //int køn1 = 0;   // 0 = mand

                //string navn2 = "lene";
                //int alder2 = 51;
                //int køn2 = 1;   // 1 = kvinde

                string navn1 = "mikkel";
                int alder1 = 15;
                Køn køn1 = Køn.Mand;
                Console.WriteLine(køn1);


                string navn2 = "lene";
                int alder2 = 51;
                Køn køn2 = Køn.Kvinde;

                DayOfWeek d = DayOfWeek.Friday;
                if (d == DayOfWeek.Friday) { }

                switch (d)
                {
                    case DayOfWeek.Sunday:



                        break;
                    case DayOfWeek.Monday:



                        break;
                    case DayOfWeek.Tuesday:



                        break;
                    case DayOfWeek.Wednesday:
                        break;
                    case DayOfWeek.Thursday:
                        break;
                    case DayOfWeek.Friday:
                        break;
                    case DayOfWeek.Saturday:
                        break;
                    default:
                        break;
                }

                SaveAction a = SaveAction.Rest;

                switch (a)
                {
                    case SaveAction.Db:


                        break;
                    case SaveAction.IO:


                        break;
                    case SaveAction.Rest:


                        break;
                    default:
                        break;
                }

                //Console.ForegroundColor = ConsoleColor.DarkMagenta;
                //Console.WriteLine("lkwjægslkj");

            }

            {


                string navn1 = "mikkel";
                int alder1 = 15;
                Køn køn1 = Køn.Mand;
                Console.WriteLine(køn1);

                string navn2 = "lene";
                int alder2 = 51;
                Køn køn2 = Køn.Kvinde;

                Person p0 = new Person();
                //p0.Alder = 0;
                p0.Alder = p0.Alder + 1;


                Person p1 = new Person();
                p1.Alder = 15;
                p1.Køn = Køn.Mand;
                p1.Navn = "Mikkel";

                int y = 1;
                Person p2 = new Person()
                {
                    Navn = "Lene",
                    Alder = 51,
                    Køn = Køn.Kvinde
                };

                Console.WriteLine(p2.Navn);

                Gem(p2);

                p1.Gem();
                //p2.Gem();

            }

            {
                Person p1 = new Person();
                p1.Navn = "Mikkel";
                p1.Alder = 15;
                p1.TalerEngelsk = true;

                // Værdier kopieres fra p1 til p2
                Person p2 = p1;
                Person p3 = new Person();
                p1.Navn = p3.Navn;

                p3 = p1;


                Console.WriteLine($"p1.Navn = { p1.Navn }");
                Console.WriteLine($"p2.Navn = { p2.Navn }");

                p2.Navn = "Mathias";
                p2.Alder = 12;

                Console.WriteLine($"p1.Navn = { p1.Navn }");
                Console.WriteLine($"p2.Navn = { p2.Navn }");


            }

            if (System.Diagnostics.Debugger.IsAttached)
            {
                Console.Write("Press any key to continue . . . ");
                Console.ReadKey();
            }

        }

        static void Gem(Person p)
        {
            System.IO.File.WriteAllText(@"c:\temp\data.txt", p.Navn + " alder: " + p.Alder);
        }

    }

    enum Køn
    {
        Mand,
        Kvinde
    }

    enum KortKulør
    {
        Spar,
        Hjerter,
        Ruder,
        Klør
    }

    enum SaveAction
    {
        Db,
        IO,
        Rest
    }

    struct Person
    {
        public string Navn;
        public int Alder;
        public Køn Køn;
        public bool TalerEngelsk;
        

        public void Gem()
        {
            System.IO.File.WriteAllText(@"c:\temp\data.txt", this.Navn + " alder: " + this.Alder);
        }

        public void Hent()
        {

        }
    }
}

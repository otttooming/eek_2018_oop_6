using System;
using System.Collections;
using System.Collections.Generic;

namespace eek_2018_oop_6
{
    public delegate void tootmisprotsess(); // delegatsiooni deklareerimine

    class Program
    {
        public static event tootmisprotsess syndmusedProts;

        static List<tootmisprotsess> tootmisprotsessid = new List<tootmisprotsess>();

        public static void FR() { Console.WriteLine("Teostamisel on freesimine"); }
        public static void LI() { Console.WriteLine("Teostamisel on lihvimine"); }
        public static void VA() { Console.WriteLine("Teostamisel on varvimine"); }
        public static void KK() { Console.WriteLine("Kvaliteedi kontroll"); }
        public static void TE() { Console.WriteLine("Testimine"); }

        static void Main(string[] args)
        {
            // Create delegation function object
            tootmisprotsess prFR = new tootmisprotsess(FR);
            tootmisprotsess prLI = new tootmisprotsess(LI);
            tootmisprotsess prVA = new tootmisprotsess(VA);
            tootmisprotsess prKK = new tootmisprotsess(KK);
            tootmisprotsess prTE = new tootmisprotsess(TE);

            // Lisa delegaatfuntisioonide objektiivid massiivi
            // mida meil on vooo1imalik proge too kaigus muuta
            tootmisprotsessid.Add(prFR);
            tootmisprotsessid.Add(prLI);
            tootmisprotsessid.Add(prVA);
            tootmisprotsessid.Add(prKK);
            tootmisprotsessid.Add(prTE);

            // Lisame kontrolli ka vahepeale
            tootmisprotsessid.Insert(1, prKK);

            Console.WriteLine("\nLisatud taiendavad kvaliteedi kontrollid");
            foreach(tootmisprotsess x in tootmisprotsessid)
            {
                x();
            }

            Console.WriteLine("\nSarnane too syndmuste abil");
            syndmusedProts += prFR;
            syndmusedProts += prLI;
            syndmusedProts += prVA;
            syndmusedProts += prKK;
            syndmusedProts += prTE;

            syndmusedProts();

            Console.WriteLine("\n Indekseerimine - Fionacci arvude naide");

            Fibonacci f = new Fibonacci();
            for (int i = 0; i < 51; i++)
            {
                Console.WriteLine("{0,2} {1,15}",i,f[i]);
            }

            // Hashtable (paaride hulk voti ja vaartus)
            Console.WriteLine("\n Hashtable (paaride hulk voti ja vaartus)");
            Toode telefon = new Toode("Phone", 123);
            Console.WriteLine("{0}", telefon);

            Tootmine Tootmisobjektid = new Tootmine();
            Tootmisobjektid["telefon"] = telefon;
            Tootmisobjektid["telefon2"] = new Toode("Samsung", 659);
            Tootmisobjektid["arvuti"] = new Toode("Palo alto", 45);
            Tootmisobjektid["telex"] = new Toode("France", 59);
            Tootmisobjektid["usenet"] = new Toode("Compuserve", 987);

            Console.WriteLine("{0}", Tootmisobjektid["arvuti"]);

            Console.Read();
        }
    }
}

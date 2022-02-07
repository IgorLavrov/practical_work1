using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practical_work1
{
    class ulesanded
    {
        public static void Main(string[] args)
        {
            Console.Write("Mis sinu nimi on ? ");
            string eesnimi1 = Console.ReadLine();

            Console.Write("ja Mis sinu nimi on ? ");
            string eesnimi2 = Console.ReadLine();

            if (eesnimi1.ToLower() != "" || eesnimi2.ToUpper() != "")
            {
                Console.WriteLine("{0} sinu pinginaber on {1}", eesnimi2, eesnimi1);
            }

            Console.ReadKey();

            Console.WriteLine(" Mis on A toa  seinte pikkus");
            int pikkusA = int.Parse(Console.ReadLine());
            Console.WriteLine(" Mis on B toa  seinte pikkus");
            int pikkusB = int.Parse(Console.ReadLine());
            Console.WriteLine(" kas te tahate remondi teha");
            string vastus = Console.ReadLine();
            if (vastus.ToUpper() == "YES")
            {
                Console.WriteLine("Kui  palju makseb  uks rumm metrid");
                int vastus1 = int.Parse(Console.ReadLine());
                int S = (pikkusA + pikkusB) * 2;
                Console.WriteLine("S {0}", S);

            }
            else
            {
                Console.WriteLine(" Nagemist!");
            }
        }
    }
}
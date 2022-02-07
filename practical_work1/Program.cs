using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practical_work1
{
    class Program
    {
        public static void Main(string[] args)
        {
            double hind = 10;
            string pileti_tuup = "tais pilet";
            Console.Write("Mis sinu nimi on ? ");
            string eesnimi = Console.ReadLine();
            //Readline - read line and wait for Enter.
            //Readkey - read any key.

            Console.WriteLine("Tere tulemast! {0} ", eesnimi);

            /*  while (eesnimi.ToLower() != "juhu")
              {
                  if (eesnimi.ToLower() == "juhu")
                  {
                      Console.WriteLine("Lahme kino");
                  }
                 else if( eesnimi.ToUpper()=="exit")
                  {
                      break;
                      }
                  else
                      {
                          Console.WriteLine("  Ma ei saa tana minna");
                      }
 
              }*/

            if (eesnimi.ToLower() == "juhu")
            {

                Console.WriteLine("Lahme kino");
                string vastus = Console.ReadLine();

                if (vastus.ToUpper() == "JAH" || vastus.ToUpper() == "YES")
                {
                    Console.WriteLine("kui vana sa oled ? ");
                    int vanus = int.Parse(Console.ReadLine());

                    if (vanus < 0 || vanus > 108)
                    {
                        Console.WriteLine("Viga!");
                        Console.ReadKey();
                        System.Environment.Exit(0);

                    }
                    else if (vanus < 6 || vanus > 65)
                    {
                        hind -= hind * 1;
                        pileti_tuup = "tasuta";

                    }
                    else if (vanus >= 6 && vanus < 12)
                    {
                        hind -= hind * 0.3;
                        pileti_tuup = "laste pilet";
                    }
                    else if (vanus >= 12 && vanus < 18)
                    {
                        hind -= hind * 0.1;
                        pileti_tuup = "opilane pilet";

                    }
                    else if (vanus < 0 && vanus > 108)
                    {
                        Console.WriteLine("Viga!");

                    }

                    if (hind < 10)
                    {

                        Console.WriteLine("Soodus hind");
                    }
                    /*
                    char[] tahed = eesnimi.ToCharArray();
                    int i = 0;
                    eesnimi = "";
                    foreach(var t in tahed)
                    {
                        if (i == 0)
                        {
                            eesnimi += t.ToString().ToUpper();
                        }
                        else
                        {
                            eesnimi += t.ToString().ToLower();
                        }
                        i += 1;
                    }
                    */

                    Console.WriteLine("{0},sul vaja {1} maksta {2}", char.ToUpper(eesnimi[0]) + eesnimi.Substring(1), pileti_tuup, hind);
                }
                else
                {
                    if (vastus.ToLower() == "no")
                    {
                        Console.WriteLine("voib olla Teist korda");
                    }
                    else
                    {
                        Console.WriteLine("ma ei saa aru, ma helistan teile hiljem");
                    }
                }

            }
            else

            {
                Console.WriteLine("Ma ei saa tana minna");
            }

            Console.ReadKey();

        }
    }
}

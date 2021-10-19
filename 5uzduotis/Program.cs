using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace _5uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = "../../Failas.txt";

            IvedimasIFaila(path);

            NuskaitytiIsFailo(path);
            


            Console.ReadKey();

        }

        static void IvedimasIFaila(string path)
        {
            string duomenys;

            Console.WriteLine("Iveskite, ka norite irasyti i faila");
            duomenys = Console.ReadLine();

            try { 
                using (StreamWriter sw = new StreamWriter(path))
                {

                        sw.WriteLine(duomenys);
                }
            }
            catch(Exception e)
            {
                Console.WriteLine($"Ivyko klaida: {e.Message}");
            }
        }

        static void NuskaitytiIsFailo(string path)
        {
            string duomenys;

            try
            {
                using(StreamReader sr = new StreamReader(path))
                {
                    duomenys = sr.ReadToEnd();
                    Console.WriteLine($"Is failo buvo nuskaityta: \n{duomenys}");
                }
            }
            catch(Exception e)
            {
                Console.WriteLine($"Ivyko klaida: {e.Message}");
            }
        }
    }
}

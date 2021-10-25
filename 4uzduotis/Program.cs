using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            WordDatabase zodziuLaikmena = new WordDatabase();

            Ivedimas(zodziuLaikmena);

            Console.WriteLine();

            zodziuLaikmena.Isvedimas();



            Console.ReadKey();
        }

        static void Ivedimas(WordDatabase wDB)
        {
            Console.WriteLine("Pradedamas ivedimas, pasikartojantys zodziai nebus issaugoti\nNorint baigti ivedima suvesti \"baigti\"");
            string zodis = "";
            while (zodis != "baigti")
            {
                Console.WriteLine("Iveskite zodi:");
                zodis = Console.ReadLine();
                if (wDB.ArEgzistuoja(zodis) && zodis != "baigti")
                {
                    Console.WriteLine($"Zodis \"{zodis}\" kartojasi ir nebus issaugotas");
                }
                else if (zodis != "baigti")
                {
                    wDB.Ivesti(zodis);
                    Console.WriteLine($"\"{zodis}\" buvo issaugotas!");
                }
            }
        }


    }
}

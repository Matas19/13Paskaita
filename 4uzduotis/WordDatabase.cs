using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4uzduotis
{
    class WordDatabase
    {
        private List<string> _Zodziai;

        public WordDatabase()
        {
            _Zodziai = new List<string>();
        }

        public void Ivedimas()
        {
            Console.WriteLine("Pradedamas ivedimas, pasikartojantys zodziai nebus issaugoti\nNorint baigti ivedima suvesti \"baigti\"");
            string zodis = "";
            while(zodis != "baigti")
            {
                Console.WriteLine("Iveskite zodi:");
                zodis = Console.ReadLine();
                if (_Zodziai.Contains(zodis) && zodis != "baigti")
                {
                    Console.WriteLine($"Zodis \"{zodis}\" kartojasi ir nebus issaugotas");
                }
                else if(zodis != "baigti")
                {
                    _Zodziai.Add(zodis);
                    Console.WriteLine($"\"{zodis}\" buvo issaugotas!");
                }
            }
        }
        
        public void Isvedimas()
        {
            Console.WriteLine("Isaugoti zodziai:");
            foreach(string zodis in _Zodziai)
            {
                Console.WriteLine(zodis);
            }
        }
    }
}

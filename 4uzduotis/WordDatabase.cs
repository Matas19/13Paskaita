using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4uzduotis
{
    class WordDatabase
    {
        private List<string> _zodziai;

        public WordDatabase()
        {
            _zodziai = new List<string>();
        }

        public void Ivesti(string zodis)
        {
            _zodziai.Add(zodis);
        }

        public bool ArEgzistuoja(string zodis)
        {
            if (_zodziai.Contains(zodis))
            {
                return true;
            }

            return false;
        }
        
        public void Isvedimas()
        {
            Console.WriteLine("Isaugoti zodziai:");
            foreach(string zodis in _zodziai)
            {
                Console.WriteLine(zodis);
            }
        }
    }
}

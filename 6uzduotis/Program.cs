using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = "../../text.txt";

            Veiksmai.TikrintiFaila(path);

            string test = "testinis tekstas";
            Veiksmai.Ivesti(path, test);

            Console.ReadKey();
        }
    }
}

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
            string errPath = "../../errLog.txt";

            string irasas = "test";

            Console.WriteLine($"Ar irasas \"{irasas}\" egzistuoja faile? ");
            Console.WriteLine(Veiksmai.TikrintiFaila(irasas, path, errPath));
            

            string test = "testinis tekstas";
            Veiksmai.Ivesti(path, test, errPath);

            Console.ReadKey();
        }
    }
}

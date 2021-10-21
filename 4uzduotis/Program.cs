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

            zodziuLaikmena.Ivedimas();

            Console.WriteLine();

            zodziuLaikmena.Isvedimas();



            Console.ReadKey();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8uzduotis_v2._0
{
    class Program
    {
        static void Main(string[] args)
        {
            string studentuFailas = "../../Studentai.txt";
            string destytojuFailas = "../../Destytojai.txt";

            Rusiuotojas sort = new Rusiuotojas(studentuFailas, destytojuFailas);

            sort.IsvetiRusiuota();



            Console.ReadKey();
        }
    }
    
}

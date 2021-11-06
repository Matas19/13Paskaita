using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            List<double> skaiciai = new List<double>();

            Ivedimas(skaiciai);
            Isvedimas(skaiciai);

            Console.ReadKey();
        }


        static void Ivedimas(List<double> skaiciai)
        {
            double skaicius = 1;
            while(skaicius != 0)
            {
                try { 
                    Console.WriteLine("Iveskite skaicius (ivedus 0 bus sustabdytas ivedimas):");
                    skaicius = Convert.ToDouble(Console.ReadLine());
                    if(skaicius != 0)
                    {
                        skaiciai.Add(skaicius);
                    }
                }
                catch(Exception e)
                {
                    Console.WriteLine($"Ivyko klaida: {e.Message}");
                }
            }
        }

        static void Isvedimas(List<double> skaiciai)
        {
            foreach(double sk in skaiciai)
            {
                Console.Write($"{sk} ");
            }
        }
    }
}

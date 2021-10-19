using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            int amzius;
            amzius = Amzius();
            Galimybes(amzius);

            Console.ReadKey();
        }

        static int Amzius()
        {
            
            int amzius = 0;
            bool tikrinimas = true;
            while (tikrinimas) 
            {
                Console.WriteLine("Iveskite savo amziu:");
                try
                {
                    amzius = Convert.ToInt32(Console.ReadLine());
                    if (amzius < 0) throw new ArgumentOutOfRangeException("Amzius negali buti mazesnis nei 0");
                    tikrinimas = false;
                }
            
                catch(Exception e)
                {
                    Console.WriteLine($"Ivyko klaida: {e.Message}");
                }
            }
            return amzius;
        }
        static void Galimybes(int amzius)
        {
            if (amzius < 18)
            {
                Console.WriteLine("Negalite nei vairuoti, nei pirkti alkoholio");
            }
            else if(amzius <= 20)
            {
                Console.WriteLine("Galite vairuoti, bet negalite pirkti alkoholio");
            }
            else
            {
                Console.WriteLine("Galite ir vairuoti ir pirkti alkoholi");
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            List<double> skaiciai = new List<double>();

            SkaiciuIvedimas(skaiciai);
            Isvedimas(skaiciai);

            Console.ReadKey();
        }

        static void SkaiciuIvedimas(List<double> skaiciai)
        {
            Console.WriteLine("Visi vedami skaiciai turi buti teigiami");
            double sk;
            while (skaiciai.Count < 4)
            {
                try
                {
                    Console.WriteLine("Iveskite skaiciu:");
                    sk = Convert.ToDouble(Console.ReadLine());
                    if(sk<0)                   //jei skaicius yra neigiamas, sukuria iskviecia nauja exception'a, kuris neleidzia ivesti skaiciaus i lista
                    {
                        throw new ArgumentOutOfRangeException("Skaicius turi buti teigiams");
                    }
                    skaiciai.Add(sk);
                }
                catch(Exception e)
                {
                    Console.WriteLine($"Ivyko klaida: {e.Message}");
                }
            }
        }

        static void Isvedimas(List<double> skaiciai)
        {
            //suma
            double suma = 0;
            foreach(double sk in skaiciai)
            {
                suma += sk;
            }

            //atimtis
            double atimtis = 0;
            foreach(double sk in skaiciai)
            {
                if (skaiciai.IndexOf(sk) == 0)      //jei tai yra pirmas paimtas skaicius, ji priskiriame atimties reiksmei, is kurios atimsime kitus skaicius
                {
                    atimtis = sk;
                }
                else
                {
                    atimtis -= sk;
                }
            }

            //daugyba
            double daugyba = 0;
            foreach (double sk in skaiciai)
            {
                if (skaiciai.IndexOf(sk) == 0)      //jei tai yra pirmas paimtas skaicius, ji priskiriame daugybos reiksmei, kuria dauginsime is kitu
                {
                    daugyba = sk;
                }
                else
                {
                    daugyba *= sk;
                }
            }

            //dalyba
            double dalyba = 0;
            foreach (double sk in skaiciai)
            {
                if (skaiciai.IndexOf(sk) == 0)      //jei tai yra pirmas paimtas skaicius, ji priskiriame dalybos reiksmei, kuria veliau dalinsim
                {
                    dalyba = sk;
                }
                else
                {
                    dalyba /= sk;
                }
            }

            //idvedimas i ekrana

            Console.WriteLine($"Suma {suma}\nAtimtis {atimtis}\nDaugyba {daugyba}\nDalyba {dalyba}");

        }
    }
}

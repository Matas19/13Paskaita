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

            IvestiSkaicius(skaiciai);
            Isvesti(skaiciai);

            Console.ReadKey();
        }

        static void IvestiSkaicius(List<double> skaiciai)
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

        static void Isvesti(List<double> skaiciai)
        {
            //suma
            double suma = GautiSuma(skaiciai);

            //atimtis
            double atimtis = GautiAtimti(skaiciai);

            //daugyba
            double daugyba = Sudauginti(skaiciai);

            //dalyba
            double dalyba = Padalinti(skaiciai);

            //idvedimas i ekrana

            Console.WriteLine($"Suma {suma}\nAtimtis {atimtis}\nDaugyba {daugyba}\nDalyba {dalyba}");

        }

        private static double Padalinti(List<double> skaiciai)
        {
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

            return dalyba;
        }

        private static double Sudauginti(List<double> skaiciai)
        {
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

            return daugyba;
        }

        private static double GautiAtimti(List<double> skaiciai)
        {
            double atimtis = 0;
            foreach (double sk in skaiciai)
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

            return atimtis;
        }

        private static double GautiSuma(List<double> skaiciai)
        {
            double suma = 0;
            foreach (double sk in skaiciai)
            {
                suma += sk;
            }

            return suma;
        }
    }
}

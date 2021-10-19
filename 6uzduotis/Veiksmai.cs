﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6uzduotis
{
    static class Veiksmai
    {

        public static string TikrintiFaila(string path)
        {
            try
            {
                if (File.Exists(path))
                {
                    return "taip";
                }
                else
                {
                    Console.WriteLine("Failas neegzistuoja arba nurodytas kelias i ji yra blogas");
                }
            }
            catch(Exception e)
            {
                Console.WriteLine($"Ivyko klaida: {e.Message}");
                using (StreamWriter sw = File.CreateText("../../error.txt"))
                {
                    sw.WriteLine($"ivyko klaida\n{e}");
                }
            }
            return "ne";
        }

        public static void Ivesti(string path, string duomenys)
        {
            try
            {
                using(StreamWriter sr = new StreamWriter(path))
                {
                    sr.WriteLine(duomenys);
                }
            }
            catch(Exception e)
            {
                Console.WriteLine($"Ivyko klaida: {e.Message}");
                using (StreamWriter sw = File.CreateText("../../error.txt"))
                {
                    sw.WriteLine($"ivyko klaida\n{e}");
                }
            }
        }
    }
}
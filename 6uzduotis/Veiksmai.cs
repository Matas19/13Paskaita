using System;
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
            try                             //ivykus klaidai, gautas exceptionas bus issaugomas i faila
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
                using (StreamWriter sw = File.AppendText("../../error.txt"))        //sukuria nauja faila arba atidaro streamWriteri kuris prides teksta prie jau egzistuojancio failo
                {
                    sw.WriteLine($"ivyko klaida\n{e}");
                }
            }
            return "ne";
        }

        public static void Ivesti(string path, string duomenys)
        {
            try                       //ivykus klaidai, gautas exceptionas bus issaugomas i faila
            {
                
                using(StreamWriter sr = new StreamWriter(path))
                {
                    sr.WriteLine(duomenys);
                }
            }
            catch(Exception e)
            {
                Console.WriteLine($"Ivyko klaida: {e.Message}");
                using (StreamWriter sw = File.AppendText("../../error.txt"))    //sukuria nauja faila arba atidaro streamWriteri kuris prides teksta prie jau egzistuojancio failo
                {
                    sw.WriteLine($"ivyko klaida\n{e}");
                }
            }
        }
    }
}

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
        public static string TikrintiFaila(string irasas, string path, string errPath)
        {
            try                             //ivykus klaidai, gautas exceptionas bus issaugomas i faila
            {
                if (File.Exists(path))
                {
                    using(StreamReader sr = new StreamReader(path))
                    {
                        string duom = sr.ReadToEnd();
                        if (duom.Contains(irasas))
                        {
                            return "taip";
                        }
                    }
                }
                else
                {
                    Console.WriteLine("Failas neegzistuoja arba nurodytas kelias i ji yra blogas");
                }
            }
            catch(Exception e)
            {
                IrasytiKlaida(e, errPath);
            }
            return "ne";
        }

        public static void Ivesti(string path, string duomenys, string errPath)
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
                IrasytiKlaida(e, errPath);
            }
        }

        private static void IrasytiKlaida(Exception e, string errPath)
        {
            Console.WriteLine($"Ivyko klaida {e.Message}");
            using(StreamWriter sw = File.AppendText(errPath))
            {
                sw.WriteLine($"Ivyko klaida: {e}");
            }
        }
    }


}

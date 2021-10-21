using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace _7uzduotis
{
    class UserDatabase
    {
        private readonly string _path = "../../vartotojai.txt";

        public UserDatabase()
        {

            File.WriteAllText(_path, "pirmas 123456\nantras password\n");

        }

        public bool ArEgzistuojaFaile(string name)
        {
            string eilute = "";
            using(StreamReader sr = File.OpenText(_path))
            {
                
                while (eilute != null)  //sukasi kol nuskaityta eilute bus failo pabaiga
                {
                    eilute = sr.ReadLine();
                    if (eilute != null)         //tikrina ar nuskaityta eilute nera paskutine
                    {
                        string[] duomenys = eilute.Split(' ');  //sukapoja string eilute i atskirus zodzius
                        if (duomenys[0] == name)
                        {
                            return true;
                        }
                    }
                }
            }

            return false;
        }



        public bool TikrintiPasswordFaile(string name, string pasw)
        {
            string eilute = "";
            using (StreamReader sr = File.OpenText(_path))
            {

                while (eilute != null)  //sukasi kol nenuskaito failo pabaigos
                {
                    eilute = sr.ReadLine();
                    if (eilute != null)         //tikrina ar nuskaityta eilute nera paskutine
                    {
                        string[] duomenys = eilute.Split(' ');  //sukapoja string eilute i atskirus zodzius
                        if (duomenys[0] == name && duomenys[1] == pasw)     //patikrina ar username ir paswordas sutampa
                        {
                            return true;
                        }
                    }
                }
            }

            return false;
        }

        public void PridetiVartotoja(string name, string pasw)
        {
            
            using(StreamWriter sw = File.AppendText(_path))
            {
                sw.WriteLine($"{name} {pasw}");
            }
        }
    }
}

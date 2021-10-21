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
        public List<Vartotojas> Vartotojai { get; private set; }
        private readonly string _path = "../../vartotojai.txt";

        public UserDatabase()
        {
            Vartotojai = new List<Vartotojas>();
            Vartotojai.Add(new Vartotojas("pirmas", "123456"));
            Vartotojai.Add(new Vartotojas("antras", "password"));
            File.WriteAllText(_path, "pirmas 123456\nantras password\n");

        }

        //metodas tikrina ar egzistuoja vartotojas, jei egzistuoja, grazina jo index'a vartotoju liste, jei ne grazina -1
        public int ArEgzistuoja(string name)    
        {
            foreach(Vartotojas user in Vartotojai)
            {
                if(user.GautiUsername() == name)
                {
                    return Vartotojai.IndexOf(user);
                }
            }
            
            return -1;
        }

        public bool TikrintiPassword(string pasw , int index)
        {
            return Vartotojai[index].TikrintiPassword(pasw);

            
        }

        public void PridetiVartotoja(string name, string pasw)
        {
            Vartotojai.Add(new Vartotojas(name, pasw));
            using(StreamWriter sw = File.AppendText(_path))
            {
                sw.WriteLine($"{name} {pasw}");
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7uzduotis
{
    class Svetaine
    {
        public string Pavadinimas {get;}
        public UserDatabase Duombaze { get; }

        public Svetaine(string pav)
        {
            Pavadinimas = pav;
            Duombaze = new UserDatabase();
        }

        public void PradetiDarba()
        {
            Console.WriteLine($"Sveiki atvyke i svetaine \"{Pavadinimas}\"");
            

            string pasirinkimas = "";
            while (pasirinkimas != "atsijungti")
            {
                Console.WriteLine("Iveskite ka norite daryti:");
                Console.WriteLine("prisijungti/registruotis/atsijungti");
                pasirinkimas = Console.ReadLine().ToLower();
                if(pasirinkimas == "prisijungti")
                {
                    Prisijungti();
                }
                else if(pasirinkimas == "registruotis")
                {
                    Registruotis();
                }
                else if(pasirinkimas == "atsijungti")
                {
                    Console.WriteLine("Viso gero!");
                }
                else
                {
                    Console.WriteLine("Blogas pasirinkimas!!! Kartokite");
                }
                Console.WriteLine();
            }
        }


        private void Prisijungti()
        {
            string username, password;
            bool kartoti = true;

            while (kartoti) { 
                Console.Write("Iveskite savo username: ");
                username = Console.ReadLine();
                Console.Write("Iveskite savo password: ");
                password = Console.ReadLine();

                
                bool egzistuoja = Duombaze.ArEgzistuojaFaile(username);
                bool prisijungta;

            
                if(!egzistuoja)       //tikrina ar egzistuoja vartotojas su pasirinktu username
                {
                    Console.WriteLine("Vartotojo su tokiu username nera");
                    kartoti = Kartoti();                //paklausia vartotojo ar jis nori kartoti prisijungima
                }
                else            //jei egzistuoja, patikrina ar atitinka slaptazodziai
                {
                    prisijungta = Duombaze.TikrintiPasswordFaile(username, password);
                    if (prisijungta == true)
                    {
                        Console.WriteLine("Sekmingai prisijungete!!!");
                        kartoti = false;            //sustabdo prisijungima
                    }
                    else
                    {
                        Console.WriteLine("Blogai ivestas vartotojo slaptazodis!");
                        kartoti = Kartoti();            //paklausia vartotojo ar jis nori kartoti prisijungima
                    }
                }
            }



        }

        private void Registruotis()
        {
            string username, password;
            bool kartoti = true;

            while (kartoti)
            {
                Console.Write("Iveskite nauja username: ");
                username = Console.ReadLine();
                Console.Write("Iveskite nauja password: ");
                password = Console.ReadLine();

                bool egzistuoja = Duombaze.ArEgzistuojaFaile(username);    //jei userIndex -1, vadinasi tokio vartotojo nera
                
                


                if (!egzistuoja)       //tikrina ar neegzistuoja vartotojas su pasirinktu username
                {
                    Duombaze.PridetiVartotoja(username, password);
                    Console.WriteLine("Sekmingai uzsiregistravote");
                    kartoti = false;
                }
                else            //jei egzistuoja, patikrina ar atitinka slaptazodziai
                {
                    Console.WriteLine("Toks username jau uzimtas!");
                    kartoti = Kartoti();                //paklausia vartotojo ar jis nori kartoti prisijungima
                }
            }
        }


        private bool Kartoti()
        {
            string pasirinkimas;

            while (true) { 
                Console.WriteLine("Ar norite kartoti?  taip/ne");
                pasirinkimas = Console.ReadLine().ToLower();
                if(pasirinkimas == "taip")
                {
                    return true;
                }
                if(pasirinkimas == "ne")
                {
                    return false;
                }
                Console.WriteLine("Ivestas blogas pasirinkimas! Bandykite is naujo!");
            }

        }
    }
}

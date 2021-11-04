using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8uzduotis_lambda
{
    class AsmenuSarasas
    {
        public string Pavadinimas { get; }
        public List<StudijuAsmuo> Asmenys { get; private set; }  //asmenu masyvas
        public List<int> Kursai { get; private set; }    //kursai, kuriems priklauso sie asmenys

        public AsmenuSarasas(string pav)
        {
            Asmenys = new List<StudijuAsmuo>();
            Kursai = new List<int>();
            Pavadinimas = pav;
        }

        public void Prideti(StudijuAsmuo asmuo)
        {
            if (!Asmenys.Contains(asmuo))   //prideda nauja asmeni i sarasa tik tada, jei sarase jo nera
            {
                Asmenys.Add(asmuo);
                if (!Kursai.Contains(asmuo.Kursas)) //patikrina ar jau yra issaugotas toks kursas, jei ne, issaugo ji
                {
                    Kursai.Add(asmuo.Kursas);
                    Kursai.Sort();  //Pridejus nauja kurso skaiciu prie saraso, sarasas surusiuojamas, kad kursai butu surasyti is eiles
                }
            }
        }

        public int Kiekis() //grazina asmenu kieki sarase
        {
            return Asmenys.Count;
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace _8uzduotis_lambda
{
    class Rusiuotojas
    {
        private string _StudPath;
        private string _DestPath;
        public AsmenuSarasas Studentai { get; private set; }
        public AsmenuSarasas Destytojai { get; private set; }
        private List<int> _Kursai;

        public Rusiuotojas(string stud, string dest)
        {
            _StudPath = stud;
            _DestPath = dest;
            Studentai = new AsmenuSarasas("Studentai");
            Destytojai = new AsmenuSarasas("Destytojai");
        }



        public void PradetiDarba()
        {
            SkaitytiFaila(_DestPath, Destytojai);
            SkaitytiFaila(_StudPath, Studentai);
            Isvedimas();
            Console.WriteLine();
            Console.WriteLine($"Kursu kiekis: {_Kursai.Count}\nStudentu kiekis: {Studentai.Kiekis()}\nDestytoju kiekis: {Destytojai.Kiekis()}");
        }

        private void Isvedimas()
        {
            RastiKursus();  //sujungia turimus studentu ir destytoju kursus
            foreach(int item in _Kursai)
            {
                Console.WriteLine($"Kursas: {item}");
                IsvestiPagalKursa(item, Destytojai);
                IsvestiPagalKursa(item, Studentai);
            }
        }

        private void RastiKursus()
        {
            _Kursai = Studentai.Kursai.Union(Destytojai.Kursai).ToList();
        }
        private void IsvestiPagalKursa(int kursas, AsmenuSarasas sarasas)
        {
            var atrinkti = sarasas.Asmenys.FindAll(s => s.Kursas == kursas);    //suranda visus asmenis atitinkancius kursa
            if(atrinkti.Count != 0)     //jei rastu asmenu sarasas ne tuscias tesia darba
            {
                Console.WriteLine($"{sarasas.Pavadinimas}:");
                foreach (var asmuo in atrinkti)
                {
                    Console.WriteLine($"{asmuo.Vardas} {asmuo.Pavarde}");
                }
            }
            
        } 

        private void SkaitytiFaila(string path, AsmenuSarasas sarasas)
        {

            string duomenys;
            StudijuAsmuo asmuo; //laikinas kintamasis
            string[] duomMasyvas;
            try
            {

                using (StreamReader sr = new StreamReader(path))
                {                                  
                    while (!sr.EndOfStream) //sukasi kol nuskaitoma paskutine
                    {
                        duomenys = sr.ReadLine();
                        duomMasyvas = duomenys.Split(' '); //Gauta duomenu eiluta isskaidoma i atskirus elementus kuriuos skire tarpas
                        asmuo = new StudijuAsmuo(duomMasyvas[0], duomMasyvas[1], Convert.ToInt32(duomMasyvas[2]));


                        sarasas.Prideti(asmuo);
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine($"Ivyko klaida: {e.Message}");
            }
        }
    }
}

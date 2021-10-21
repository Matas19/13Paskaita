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
        private int _StudKiekis;
        private int _DestKiekis;
        public int _Kursai { get; private set; }
        public List<string[]> studentai { get; private set; }
        public List<string[]> destytojai { get; private set; }

        public Rusiuotojas(string stud, string dest)
        {
            _Kursai = 0;
            _StudPath = stud;
            _DestPath = dest;
            _StudKiekis = 0;
            _DestKiekis = 0;
            studentai = new List<string[]>();
            destytojai = new List<string[]>();
        }



        public void IsvetiRusiuota()
        {
            RastiKursaIrKieki(_DestPath, out _DestKiekis, destytojai);
            RastiKursaIrKieki(_StudPath, out _StudKiekis, studentai);

            for (int i = 1; i <= _Kursai; i++)
            {
                Console.WriteLine($"Kursas: {i}");
                Console.WriteLine("Destytojai: ");
                IsvestiPagalKursa(i, destytojai);
                Console.WriteLine("Studentai: ");
                IsvestiPagalKursa(i, studentai);
            }
            Console.WriteLine();
            Console.WriteLine($"Kursu kiekis: {_Kursai}\nStudentu kiekis: {_StudKiekis}\nDestytoju kiekis: {_DestKiekis}");
        }


        private void IsvestiPagalKursa(int kursas, List<string[]> listas)
        {
            var atrinkti = listas.FindAll(s => s[2] == kursas.ToString());
            foreach (var asmuo in atrinkti)
            {
                Console.WriteLine($"{asmuo[0]} {asmuo[1]}");
            }
        }

        private void RastiKursaIrKieki(string path, out int kiekis, List<string[]> listas)
        {

            kiekis = 0;
            string duomenys;
            string[] duomMasyvas;
            try
            {

                using (StreamReader sr = new StreamReader(path))
                {
                    duomenys = sr.ReadLine();
                    while (duomenys != null) //sukasi kol nuskaitoma paskutine
                    {
                        kiekis++;  //skaiciuoja asmenis

                        if (duomenys != null)   //patikrina ar nuskaityta eilute netuscia
                        {
                            duomMasyvas = duomenys.Split(' '); //Gauta duomenu eiluta isskaidoma i atskirus elementus kuriuos skire tarpas

                            if (_Kursai < Convert.ToInt32(duomMasyvas[2])) //iesko didesnio kurso nei yra issaugotas, jei randa, tai buna naujas kursu kiekis
                            {
                                _Kursai = Convert.ToInt32(duomMasyvas[2]);
                            }
                            listas.Add(duomMasyvas);

                        }
                        duomenys = sr.ReadLine();
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

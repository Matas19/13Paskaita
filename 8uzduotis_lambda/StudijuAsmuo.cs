using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8uzduotis_lambda
{
    //Kadangi sioje uzduotyje ir studentas ir destytojas yra aprasomi taip pat, tai jiems naudosiu ta pacia 
    class StudijuAsmuo : Asmuo
    {
        public int Kursas { get; }

        public StudijuAsmuo(string vardas, string pav, int kursas) : base(vardas, pav)
        {
            Kursas = kursas;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8uzduotis_lambda
{
    abstract class Asmuo
    {
        public string Vardas { get; private set; }
        public string Pavarde { get; private set; }

        public  Asmuo(string vardas, string pav)
        {
            Vardas = vardas;
            Pavarde = pav;
        }
        
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7uzduotis
{
    class Vartotojas
    {
        private string _Username;
        private string _Password;

        public Vartotojas(string username, string password)
        {
            _Username = username;
            _Password = password;
        }

        public string GautiUsername()
        {
            return _Username;
        }
        public bool TikrintiPassword(string pasw)
        {
            if (pasw == _Password)
            {
                return true;
            }

            return false;
        }
    }
}

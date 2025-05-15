using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mega_Knodel
{
    internal class Mitarbeiter : Personal
    {

        public Mitarbeiter(string name, string login, string passwort)
        {
            Name = name;
            Login = login;
            Passwort = passwort;
        }

        public void ZeigeInfo()
        {
            Console.Clear();
            Console.WriteLine($"Willkommen {Name}");

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mega_Knodel
{
    internal class PersonalListe
    {
        private static Dictionary<string, Personal> _personalListe = new Dictionary<string, Personal>()
        {
            { "mitarbeiter1", new Mitarbeiter("Name_1", "Login_1", "Passwort_1") },
            {"mitarbeiter2", new Mitarbeiter("Name_2", "Login_2", "Passwort_2") },
            { "mitarbeiter3", new Mitarbeiter("Name_3" , "Login_3", "Passwort_3") },
            { "mitarbeiter4", new Mitarbeiter("Name_4" , "Login_4", "Passwort_4") },
            { "mitarbeiter5", new Mitarbeiter("Name_5", "Login_5", "Passwort_5") },

        };
        private static Dictionary<string, Personal> _verwaltungsmitarbeiter = new Dictionary<string, Personal>()
        {

            {"chef1", new Verwaltungsmitarbeiter("chef","chef","chef") }
        };

        public static Personal AnmeldungMitarbeiter()
        {
            return Anmeldung(_personalListe);
        }
        public static Personal AnmeldungChef()
        {
            return Anmeldung(_verwaltungsmitarbeiter);
        }
        private static Personal Anmeldung(Dictionary<string, Personal> personalListe)
        {

            Personal? personal = null;
            bool gibtLogin = false;
            bool korrektesPasswort = false;

            do
            {
                Console.Clear();
                Console.Write("Gib ein Login ein: ");
                string login = (Console.ReadLine() ?? "").Trim();

                foreach (KeyValuePair<string, Personal> eintrag in personalListe)
                {
                    if (eintrag.Value.Login == login)
                    {
                        personal = eintrag.Value;
                        gibtLogin = true;
                        break;
                    }
                }
            }
            while (gibtLogin == false);


            do
            {
                Console.Clear();
                Console.Write("Gib ein Passwort ein: ");
                string passwort = (Console.ReadLine() ?? "").Trim();

                if ((personal is Mitarbeiter mitarbeiter || personal is Verwaltungsmitarbeiter chef) && passwort == personal?.Passwort) korrektesPasswort = true;

            }
            while (korrektesPasswort == false);


            return personal;

        }
    }
}

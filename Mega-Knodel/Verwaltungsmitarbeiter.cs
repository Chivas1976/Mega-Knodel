using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Mega_Knodel
{
    internal class Verwaltungsmitarbeiter  : Personal
    {

                public Verwaltungsmitarbeiter(string name, string login, string passwort)
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
    /*
        public Verwaltungsmitarbeiter(int id, string vorname, string nachname, string adresse, string telefonnummer, DateTime geburtsdatum, string gastronomiebereich) : base(id, vorname, nachname, adresse, telefonnummer, geburtsdatum,gastronomiebereich)
        {       
            gastronomiebereich = gastronomiebereich;
        }
        */
        /*
        public string override ToString()
        {
            return $"{base.ToString()},+ $ Gastronomiebereich: {gastronomiebereich}";
        }
        */
        /*
        public void MitarbeiterBearbeiten(Mitarbeiter mitarbeiter, string neuerVorname, string neuerNachname)
        {
            mitarbeiter.Vorname = neuerVorname;
            mitarbeiter.Nachname = neuerNachname;
            Console.WriteLine("Mitarbeiter wurde erfolgreich bearbeitet.");
        }
        */
        /*
        public void MitarbeiterLoeschen(List<Mitarbeiter> mitarbeiterListe, int id)
        {
            var mitarbeiter = mitarbeiterListe.Find(m => m.Id == id);
            if (mitarbeiter != null)
            {
                mitarbeiterListe.Remove(mitarbeiter);
                Console.WriteLine("Mitarbeiter wurde gelöscht.");
            }
            else
            {
                Console.WriteLine("Mitarbeiter nicht gefunden.");
            }
        }
        */
    }
}

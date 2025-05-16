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

        public void ZeigeMenu()
        {


            while (true)
            {
                Console.Clear();
                Console.WriteLine($"Willkommen {Name}\n");
                Console.WriteLine("===== Verwaltungsmitarbeiter =====");
                //   Console.WriteLine("1. Mitarbeiter bearbeiten");
                // Console.WriteLine("2. Mitarbeiter löschen");
                Console.WriteLine("1. Speisekarte anzeigen");
                Console.WriteLine("2. Bestellungen zeigen");
                Console.WriteLine("3. Beenden");

                Console.Write("Ihre Auswahl: ");


                int.TryParse(Console.ReadLine(), out int auswahlMenu);

                switch (auswahlMenu)
                {
                    case 1:
                        Console.Clear();
                        SpeisekarteAnzeigen();


                        break;
                    case 2:
                        Console.Clear();
                        Bestellung.Laden();
                        Console.ReadLine();
                        break;
                    case 3:
                        Console.Clear();

                        return; ;



                }
            }
        }
    public void SpeisekarteAnzeigen()
        {

            while (true)
            {
                Console.Clear();
                Console.WriteLine("=====  Speisekarte =====");
                Console.WriteLine("1. Produkte anzeigen");
                Console.WriteLine("2. Getränke anzeigen");
                Console.WriteLine("3. Zurück");

                Console.Write("Ihre Auswahl: ");


                int.TryParse(Console.ReadLine(), out int auswahl);
              
                switch (auswahl)
                {
                    case 1:
                        Console.Clear();
                        Menue.ZeigeProdukte();
                        PreisAenderung(ProduktAuswahl(Menue.knoedelListe));
                        break;
                    case 2:
                        Console.Clear();
                        Menue.ZeigeGetreanke();
                        PreisAenderung(ProduktAuswahl(Menue.getraenkListe));
                        // PreisAenderung();
                        break;

                    case 3:
                        Console.Clear();
                        return;

                }
            }
 
        }
        private Artikel? ProduktAuswahl(List<Artikel> artikel) {

            int id = 0;
            bool ueberpruefen = false;

            Console.WriteLine($"[0] – Zurück");

            Console.WriteLine();
            Console.Write("Bitte geben Sie die ID von Artikel ein, dessen Preis Sie ändern möchten: ");

            int x = Console.GetCursorPosition().Left;
            int y = Console.GetCursorPosition().Top;
            do
            {
               ueberpruefen =  int.TryParse((Console.ReadLine() ?? "").Trim(), out id);

                if (id > 0 && id <= artikel.Count && ueberpruefen != false)
                {
                    ueberpruefen = true;
                }
                else if (id == 0)
                {
                    return null;
                }
                else
                {
                    ueberpruefen = false;
                    Console.SetCursorPosition(x, y);
                    Console.WriteLine("                             ");
                    Console.SetCursorPosition(x, y);
                }
            }
            while (ueberpruefen == false);

            return artikel[id-1];
        }

        private void PreisAenderung(Artikel produkt)
        {
            if (produkt == null) return;

            Console.Clear();
            Console.WriteLine("=== Preis Änderung ===\n");
            Console.WriteLine($"{produkt.Name} - Alter Preis: {produkt.Preis:F2}");
            Console.Write("Bitte geben Sie den neuen Preis ein: ");

            decimal neuerPreis;
           bool ueberpruefen = false;

            int x = Console.GetCursorPosition().Left;
            int y = Console.GetCursorPosition().Top;
            do
            {
                ueberpruefen = decimal.TryParse((Console.ReadLine() ?? "").Trim().Replace(".", ","), out neuerPreis);

                if (neuerPreis > 0 && ueberpruefen != false)
                {
                    ueberpruefen = true;
                }
                else
                {
                    ueberpruefen = false;
                    Console.SetCursorPosition(x, y);
                    Console.WriteLine("                             ");
                    Console.SetCursorPosition(x, y);
                }
            } while (ueberpruefen == false);

            produkt.PreisAendern(Math.Round(neuerPreis, 2));
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

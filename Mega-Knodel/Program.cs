// See https://aka.ms/new-console-template for more information
using Mega_Knodel;
using System;
using System.Collections.Generic;
using System.Diagnostics;




class Program
{
    static List<Mitarbeiter> mitarbeiterListe = new List<Mitarbeiter>();

    static void Main(string[] args)
    {
        Hauptmenu();
    }

    static void Hauptmenu()
    {
        while (true)
        {
            Console.Clear();
            Console.WriteLine("===== Hauptmenü =====");
            Console.WriteLine("1. Chef");
            Console.WriteLine("2. Mitarbeiter");
            Console.WriteLine("3. Kunde");
            Console.WriteLine("4. Beenden");

            Console.Write("Ihre Auswahl: ");
            string auswahl = (Console.ReadLine() ?? "");

            switch (auswahl)
            {
                case "1":
                    //Cheff
                    Verwaltungsmitarbeiter chef = (Verwaltungsmitarbeiter)PersonalListe.AnmeldungChef();

                    chef.ZeigeMenu();
                    break;
                case "2":
                    //Mitarbeiter
                    Mitarbeiter personal = (Mitarbeiter)PersonalListe.AnmeldungMitarbeiter();
                    personal.ZeigeInfo();
                    break;
                case "3":
                    Kunde kunde = new Kunde();
                    kunde.BestellungAufgeben(new Bestellung());
                    break;
               
                case "4":
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Ungültige Auswahl!");
                        break;
                    }

            Console.WriteLine("\nDrücken Sie eine Taste, um fortzufahren...");
            Console.ReadKey();
        }
    }

    /*
    static void Hauptmenu()
    {
        Bestellung bestellung = new Bestellung();

        while (true)
        {
            Console.Clear();
            Console.WriteLine("===== Hauptmenü =====");
            Console.WriteLine("1. Bestellung starten");
            Console.WriteLine("2. Mitarbeiter verwalten");
            Console.WriteLine("3. Beenden");

            Console.Write("Ihre Auswahl: ");
            string auswahl = Console.ReadLine();

            switch (auswahl)
            {
                case "1":
                    bestellung.HauptMenu(); // tvoj postojeći meni za narudžbine
                    break;
                case "2":
                    MitarbeiterMenu();
                    break;
                case "3":
                    Console.WriteLine("Programm wird beendet...");
                    return;
                default:
                    Console.WriteLine("Ungültige Eingabe!");
                    break;
            }

            Console.WriteLine("\nDrücken Sie eine Taste, um fortzufahren...");
            Console.ReadKey();
        }
    }*/
    /*
    static void MitarbeiterMenu()
    {
        while (true)
        {
            Console.Clear();
            Console.WriteLine("===== Mitarbeiter-Menü =====");
            Console.WriteLine("1. Neuen Mitarbeiter hinzufügen");
            Console.WriteLine("2. Mitarbeiter anzeigen");
            Console.WriteLine("0. Zurück");

            Console.Write("Ihre Wahl: ");
            string eingabe = Console.ReadLine();

            switch (eingabe)
            {
                case "1":
                    MitarbeiterHinzufuegen();
                    break;
                case "2":
                    MitarbeiterAnzeigen();
                    break;
                case "0":
                    return;
                default:
                    Console.WriteLine("Ungültige Eingabe!");
                    break;
            }

            Console.WriteLine("\nDrücken Sie eine Taste, um fortzufahren...");
            Console.ReadKey();
        }
    }
    /*
    static void MitarbeiterHinzufuegen()
    {
        Console.Clear();
        Console.WriteLine("=== Neuer Mitarbeiter ===");

        Console.Write("Vorname: ");
        string vorname = Console.ReadLine();

        Console.Write("Nachname: ");
        string nachname = Console.ReadLine();

        Console.Write("Adresse: ");
        string adresse = Console.ReadLine();

        Console.Write("Telefonnummer: ");
        string telefonnummer = Console.ReadLine();

        Console.Write("Geburtsdatum (JJJJ-MM-TT): ");
        DateTime.TryParse(Console.ReadLine(), out DateTime geburtsdatum);

        int neueId = mitarbeiterListe.Count + 1;

        Mitarbeiter neuerMitarbeiter = new Mitarbeiter(neueId, vorname, nachname, adresse, telefonnummer, geburtsdatum);
        mitarbeiterListe.Add(neuerMitarbeiter);

        Console.WriteLine("Mitarbeiter wurde erfolgreich hinzugefügt!");
    }

    static void MitarbeiterAnzeigen()
    {
        Console.Clear();
        Console.WriteLine("=== Liste aller Mitarbeiter ===");

        if (mitarbeiterListe.Count == 0)
        {
            Console.WriteLine("Noch keine Mitarbeiter vorhanden.");
            return;
        }

        foreach (var mitarbeiter in mitarbeiterListe)
        {
            Console.WriteLine(mitarbeiter.ToString());
        }
    }
    */
}




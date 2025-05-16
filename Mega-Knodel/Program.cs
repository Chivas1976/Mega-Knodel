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
}




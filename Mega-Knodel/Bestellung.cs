using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using System.Text.Json; // Für JSON-Funktionen
using System.IO;        // Für Dateioperationen

namespace Mega_Knodel
{
    internal class Bestellung
    {
        public List<Artikel> ArtikelListe { get; set; } = new List<Artikel>();

        public DateTime Datum { get; set; } = DateTime.Now;

        public void ArtikelHinzufuegen(Artikel artikel)
        {
            if (artikel.Menge > 0)
            {
                Artikel ware = new Artikel(artikel.Id, artikel.Name, artikel.Preis, 1);

                ArtikelListe.Add(ware);

                artikel.MengeAendern();
            }


        }

        public void HauptMenu()
        {
            while (true)
            {
                Console.Clear();

                Console.WriteLine("===== Bestellung =====");
                Console.WriteLine("1. Produkt aufgeben");
                Console.WriteLine("2. Getränk aufgeben");
                Console.WriteLine("3. Beenden");
                if (ArtikelListe.Count != 0)
                {
                    Console.WriteLine("4. Kauf");
                    Console.WriteLine("5. Artikel löschen");
                    ZeigeBestellung();
                }

                int.TryParse(Console.ReadLine(), out int auswahlMenu);

                switch (auswahlMenu)
                {
                    case 1:
                        Console.Clear();
                        Menue.ZeigeProdukte();

                        AuswahlProdukt();
                        break;
                    case 2:
                        Console.Clear();
                        Menue.ZeigeGetreanke();

                        AuswahlGetraenk();
                        break;
                    case 3:
                        Console.WriteLine("Programm wird beendet...");
                        return;

                    case 4:
                        if (ArtikelListe.Count != 0)
                        {
                            Console.Clear();
                            ZeigeBestellung();
                            Console.WriteLine("\nDrücken Sie eine Taste zum Zurückkhehren...");
                            Console.ReadKey();
                        }
                        return;
                    case 5:
                        if (ArtikelListe.Count != 0)
                        {
                            Console.Clear();
                            ArtikelEntfernen();

                        }

                        break;

                }
            }
        }

        private void AuswahlProdukt()
        {
            Console.WriteLine($"[0] – Zurück");
            bool istZahl = false;

            do
            {
               istZahl = false;

                istZahl = int.TryParse(Console.ReadLine(), out int auswahl);

                if (auswahl > 0 && auswahl <= Menue.knoedelListe.Count && istZahl != false && Menue.knoedelListe[auswahl - 1].Menge != 0)
                {

                    this.ArtikelHinzufuegen(Menue.knoedelListe[auswahl - 1]);

    
                    istZahl = true;
                }
                else if (auswahl > 0 && auswahl <= Menue.knoedelListe.Count && istZahl != false && Menue.knoedelListe[auswahl - 1].Menge == 0)
                {
                    int x = Console.GetCursorPosition().Left;
                    int y = Console.GetCursorPosition().Top;

                    Console.SetCursorPosition(x, y - 1);
                    Console.WriteLine("                                                          ");
                    Console.SetCursorPosition(x, y - 1);

                    

                    Console.Write($"{Menue.knoedelListe[auswahl - 1].Name} ist leider aus.");

                    Thread.Sleep(2000);

                    Console.SetCursorPosition(x, y - 1);
                    Console.WriteLine("                                                          ");
                    Console.SetCursorPosition(x, y - 1);
                    
                    istZahl = false;
                }
                else if (auswahl == 0 && istZahl!=false) istZahl = true;
                else
                {
                    int x = Console.GetCursorPosition().Left;
                    int y = Console.GetCursorPosition().Top;

                    istZahl = false;


                    Console.SetCursorPosition(x, y - 1);
                    Console.WriteLine("                                                   ");
                    Console.SetCursorPosition(x, y - 1);
                }

            }
            while (istZahl == false);
            /*
            switch (auswahl)
            {
                case 1:
                    Console.WriteLine("Sie haben Walnuss (Walnusscreme) gewählt.");
                    this.ArtikelHinzufuegen(Menue.knoedelListe[0]);
                    break;
                case 2:
                    Console.WriteLine("Sie haben Schwarz-Weiß (Mandel und Kokos) gewählt.");
                    this.ArtikelHinzufuegen(Menue.knoedelListe[1]);
                    break;
                case 3:
                    Console.WriteLine("Sie haben Pfirsich und Ricotta gewählt.");
                    this.ArtikelHinzufuegen(Menue.knoedelListe[2]);
                    break;
                case 4:
                    Console.WriteLine("Sie haben Pistazie gewählt.");
                    this.ArtikelHinzufuegen(Menue.knoedelListe[3]);
                    break;
                case 5:
                    Console.WriteLine("Sie haben Karamell gewählt.");
                    this.ArtikelHinzufuegen(Menue.knoedelListe[4]);
                    break;
                case 6:
                    Console.WriteLine("Sie haben Nougat gewählt.");
                    this.ArtikelHinzufuegen(Menue.knoedelListe[5]);
                    break;
                case 7:
                    Console.WriteLine("Sie haben Nutella gewählt.");
                    this.ArtikelHinzufuegen(Menue.knoedelListe[6]);
                    break;
                case 8:
                    Console.WriteLine("Sie haben Praline Noisette gewählt.");
                    this.ArtikelHinzufuegen(Menue.knoedelListe[7]);
                    break;
                case 9:
                    Console.WriteLine("Sie haben Waldfrüchte gewählt.");
                    this.ArtikelHinzufuegen(Menue.knoedelListe[8]);
                    break;
                case 10:
                    Console.WriteLine("Sie haben Kirsche und Vanille gewählt.");
                    this.ArtikelHinzufuegen(Menue.knoedelListe[9]);
                    break;
                default:
                    Console.WriteLine("Ungültige Auswahl. Bitte wählen Sie eine Zahl zwischen 1 und 10.");
                    break;
            }
            */

        }
        private void AuswahlGetraenk()
        {
            Console.WriteLine($"[0] – Zurück");

            bool istZahl = false;

            do
            {
                istZahl = false;

                istZahl = int.TryParse(Console.ReadLine(), out int auswahl);

                if (auswahl > 0 && auswahl <= Menue.getraenkListe.Count && istZahl != false && Menue.getraenkListe[auswahl - 1].Menge != 0)
                {

                    this.ArtikelHinzufuegen(Menue.getraenkListe[auswahl - 1]);


                    istZahl = true;
                }
                else if (auswahl > 0 && auswahl <= Menue.getraenkListe.Count && istZahl != false && Menue.getraenkListe[auswahl - 1].Menge == 0)
                {
                    int x = Console.GetCursorPosition().Left;
                    int y = Console.GetCursorPosition().Top;

                    Console.SetCursorPosition(x, y - 1);
                    Console.WriteLine("                                                          ");
                    Console.SetCursorPosition(x, y - 1);



                    Console.Write($"{Menue.getraenkListe[auswahl - 1].Name} ist leider aus.");

                    Thread.Sleep(2000);

                    Console.SetCursorPosition(x, y - 1);
                    Console.WriteLine("                                                          ");
                    Console.SetCursorPosition(x, y - 1);

                    istZahl = false;
                }
                else if (auswahl == 0 && istZahl!=false) istZahl = true;
                else
                {
                    istZahl = false;
                    int x = Console.GetCursorPosition().Left;
                    int y = Console.GetCursorPosition().Top;

                    Console.SetCursorPosition(x, y - 1);
                    Console.WriteLine("                    ");
                    Console.SetCursorPosition(x, y - 1);
                }

            }
            while (istZahl == false);
            /*
                int.TryParse(Console.ReadLine(), out int auswahl);

                var getraenkListe = new Menue().getraenkListe;

                if (auswahl >= 1 && auswahl <= getraenkListe.Count)
                {
                    var gewaehltesGetraenk = getraenkListe[auswahl - 1];
                    Console.WriteLine($"Sie haben {gewaehltesGetraenk.Name} gewählt.");
                    ArtikelHinzufuegen(gewaehltesGetraenk); // Dodaj u porudžbinu
                }
                else
                {
                    Console.WriteLine("Ungültige Auswahl. Bitte erneut versuchen.");
                }

                Console.WriteLine("\nDrücken Sie eine Taste, um fortzufahren...");
                Console.ReadKey();
            */
        }


        public void ZeigeBestellung()
        {
            Console.WriteLine($"\nBestellung vom {Datum.ToShortDateString()}");
            decimal summe = 0;

            for (int i = 0; i < ArtikelListe.Count; i += 1)
            {
                Console.WriteLine($"[{i + 1}] - {ArtikelListe[i].ZeigeInfo()}");
                summe += ArtikelListe[i].Preis;
            }
            Console.WriteLine($"Gesamtsumme: {summe} Euro");
        }
        public void ArtikelEntfernen()
        {
            Console.WriteLine("Bitte wählen Sie den Artikel, den Sie entfernen möchten:");
            ZeigeBestellung();
            int.TryParse(Console.ReadLine(), out int auswahl);
            if (auswahl > 0 && auswahl <= ArtikelListe.Count)
            {
                ArtikelListe.RemoveAt(auswahl - 1);
                Console.WriteLine("Artikel wurde entfernt.");
            }
            else
            {
                Console.WriteLine("Ungültige Auswahl.");
            }
        }
        public void Speichern(string dateiPfad = "bestellung.json")
        {
            // Serialisiert die Bestellung in JSON
            string json = JsonSerializer.Serialize(this);

            // Speichert JSON in eine Datei
            File.WriteAllText(dateiPfad, json);

            Console.WriteLine($"Bestellung wurde gespeichert: {dateiPfad}");
        }
        public static Bestellung Laden(string dateiPfad = "bestellung.json")
        {
            // Liest JSON aus der Datei
            string json = File.ReadAllText(dateiPfad);

            // Konvertiert JSON zurück in ein Bestellung-Objekt
            return JsonSerializer.Deserialize<Bestellung>(json);
        }
    }

}

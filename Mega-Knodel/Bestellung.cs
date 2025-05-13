using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mega_Knodel
{
    internal class Bestellung
    {
        public List<Artikel> ArtikelListe { get; set; } = new List<Artikel>();
        public DateTime Datum { get; set; } = DateTime.Now;

        public void ArtikelHinzufuegen(Artikel artikel)
        {
            ArtikelListe.Add(artikel);
        }

        public void HauptMenu()
        {
            while (true)
            {
                Console.Clear();

                Console.WriteLine("===== Hauptmenü =====");
                Console.WriteLine("1. Produkt aufgeben");
                Console.WriteLine("2. Getränk aufgeben");
                Console.WriteLine("3. Beenden");
                if (ArtikelListe.Count != 0)
                {
                    Console.WriteLine("4. Kauf");

                    ZeigeBestellung();
                }

                int.TryParse(Console.ReadLine(), out int auswahlMenu);

                switch (auswahlMenu) {
                    case 1:
                        Console.Clear();
                        Menue.ZeigeProdukte();

                        AuswahlProdukt();
                        break;
                }
            }
        }

        private void AuswahlProdukt()
        {
            int.TryParse(Console.ReadLine(), out int auswahl);
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
            
        }

        public void ZeigeBestellung()
        {
            Console.WriteLine($"\nBestellung vom {Datum.ToShortDateString()}");
            decimal summe = 0;
            foreach (var artikel in ArtikelListe)
            {
                artikel.ZeigeInfo();
                summe += artikel.Preis;
            }
            Console.WriteLine($"Gesamtsumme: {summe} Euro");
        }
    }
}

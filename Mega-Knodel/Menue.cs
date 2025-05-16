using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Mega_Knodel
{
    internal class Menue
    {
        public static List<Artikel> knoedelListe = new List<Artikel>
            {
                new Produkt(1, "Walnuss (Walnusscreme)", 3.00m, 7),
                new Produkt(2, "Schwarz-Weiß (Mandel und Kokos)", 3.10m, 8),
                new Produkt(3, "Pfirsich und Ricotta", 3.00m, 4),
                new Produkt(4, "Pistazie", 3.20m, 3),
                new Produkt(5, "Karamell", 3.10m, 3),
                new Produkt(6, "Nougat", 3.50m, 10),
                new Produkt(7, "Nutella", 3.50m, 9),
                new Produkt(8, "Praline Noisette", 3.70m, 6),
                new Produkt(9, "Waldfrüchte", 3.30m, 3),
                new Produkt(10, "Kirsche und Vanille", 2.90m, 3)
        };
        public static List<Artikel> getraenkListe = new List<Artikel> 
{
    new Getraenk(1, "Espresso", 1.80m, 33),
    new Getraenk(2, "Tasenkaffee", 2.20m, 20),
    new Getraenk(3, "Cappuccino", 3.60m, 65),
    new Getraenk(4, "Latte Macchiato", 2.90m, 34),
    new Getraenk(5, "Hausgemachter Eistee", 2.00m, 4),
    new Getraenk(6, "Frischer Orangensaft", 2.50m, 7),
    new Getraenk(7, "San Pelegrino", 2.20m, 200),
    new Getraenk(8, "Coca Cola" , 3.10m, 106),
    new Getraenk(9, "Fanta", 3.10m, 45),
    new Getraenk(10, "Sprite", 3.10m,22),
    new Getraenk(11, "Mineralwasser", 1.50m, 60),
};
        
        public static void ZeigeGetreanke()
        {
            Console.WriteLine("===== Getränke auf der Speisekarte =====\n");
            for  (int i = 0; i < getraenkListe.Count; i += 1)
            {
                Console.WriteLine($"[{i + 1}] - {getraenkListe[i].ZeigeInfo()}");
            }
        }

        
        public static void ZeigeProdukte()
        {

            Console.WriteLine("===== Knodel auf der Speisekarte =====\n");
            for (int i=0; i<knoedelListe.Count; i += 1) {
                Console.WriteLine($"[{i+1}] - {knoedelListe[i].ZeigeInfo()}");
            }

        }

    }
}

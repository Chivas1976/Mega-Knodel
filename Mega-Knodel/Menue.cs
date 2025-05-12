using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mega_Knodel
{
    internal class Menue
    {
        public static List<Produkt> knoedelListe = new List<Produkt>
            {
                new Produkt(1, "Walnuss (Walnusscreme)", 3.00m),
                new Produkt(2, "Schwarz-Weiß (Mandel und Kokos)", 3.10m),
                new Produkt(3, "Pfirsich und Ricotta", 3.00m),
                new Produkt(4, "Pistazie", 3.20m),
                new Produkt(5, "Karamell", 3.10m),
                new Produkt(6, "Nougat", 3.50m),
                new Produkt(7, "Nutella", 3.50m),
                new Produkt(8, "Praline Noisette", 3.70m),
                new Produkt(9, "Waldfrüchte", 3.30m),
                new Produkt(10, "Kirsche und Vanille", 2.90m)
        };
        public List<Getraenk> getraenkListe = new List<Getraenk>
{
    new Getraenk(1, "Espresso", 1.80m),
    new Getraenk(2, "Tasenkaffee", 2.20m),
    new Getraenk(3, "Cappuccino", 3.60m),
    new Getraenk(4, "Latte Macchiato", 2.90m),
    new Getraenk(5, "Hausgemachter Eistee", 2.00m),
    new Getraenk(6, "Frischer Orangensaft", 2.50m),
    new Getraenk(7, "San Pelegrino", 2.20m),
    new Getraenk(8, "Coca Cola" , 3.10m),
    new Getraenk(9, "Fanta", 3.10m),
    new Getraenk(10, "Sprite", 3.10m),
    new Getraenk(11, "Mineralwasser", 1.50m),
};

        public void ZeigeMenü()
        {

            Console.WriteLine("===== Knodel auf der Speisekarte =====\n");
            foreach (var knodel in knoedelListe)
            {
                knodel.ZeigeInfo();
            }
            Console.WriteLine("\n===== Getränke auf der Speisekarte =====\n");

            foreach (var getraenk in getraenkListe)
            {
                getraenk.ZeigeInfo();
            }
        }
        public static void ZeigeProdukte()
        {

            Console.WriteLine("===== Knodel auf der Speisekarte =====\n");
            foreach (var knodel in knoedelListe)
            {
                knodel.ZeigeInfo();
            }

        }

    }
}

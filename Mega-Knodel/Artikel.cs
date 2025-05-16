using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Mega_Knodel
{
    internal class Artikel
    {

        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Preis { get; set; }

        public int Menge { get; set; }

        public Artikel(int id, string name, decimal preis,int menge)
        {
            Id = id;
            Name = name;
            Preis = preis;
            Menge = menge;
        }

        public string ZeigeInfo()
        {
           return $"{Name} – {Preis:F2} Euro | Menge: {Menge}";
        }

        public void MengeAendern()
        {
            Menge -= 1;
        }

        public void Preisändern(decimal neuerPreis)
        {
            Preis = neuerPreis;
        }
    }
}

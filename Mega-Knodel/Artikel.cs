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

        public Artikel(int id, string name, decimal preis)
        {
            Id = id;
            Name = name;
            Preis = preis;
        }

        public void ZeigeInfo()
        {
            Console.WriteLine($"[{Id}] {Name} – {Preis} Euro");
        }
    }
}

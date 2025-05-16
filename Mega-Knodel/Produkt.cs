using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mega_Knodel
{
    internal class Produkt:Artikel
    {
       

        public Produkt(int id, string name, decimal preis, int menge) : base(id, name, preis,menge)
        {
            
        }

       
       
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mega_Knodel
{
    internal class Kunde
    {/*
        public void SpeisekarteAnzeigen()
        {
            Menue menü = new Menue();
           // menü.ZeigeMenü();
        }
        */
        public void BestellungAufgeben(Bestellung bestellung)
        {
            bestellung.HauptMenu();
        }
    }
}

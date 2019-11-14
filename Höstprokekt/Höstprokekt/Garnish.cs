using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Höstprokekt
{
    class Garnish
    {
        Random flavour = new Random();

        public int Flavours()//En metod för randomising av flavour. Möjligen: Randomiser API?
        {
            return flavour.Next(10);
        }
        
        public enum Garnishes
        {
            Scallions,
            Ginger,
            Garlic,
            Mushroom

        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Höstprokekt
{
    class Noodles : Food
    {
        Random overCooked = new Random();
        //En metod för att se att nudlarna är överkokta eller inte. 
        public bool OverCooked()
        {
            if (overCooked.Next(3) <= 1)
            {
                return true;
            }

            return false;
        }

        public enum NoodleChoice
        {
            Soba,
            Egg,
            Rice,
            Udon
        }

    }
}

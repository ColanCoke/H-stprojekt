using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Höstprokekt
{
    public class Meat : Food
    {
        Random burning = new Random();
        public bool Burnt()
        {
            if (burning.Next(10) <= 3)
            {
                return true;
            }

            return false;
        }
    }
}

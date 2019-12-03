using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Höstprokekt
{
    public class Stock : Food
    {

        Random rich = new Random(); //En random generator för richness
        protected int Richness()
        {
            int richness = rich.Next(21);

            return richness;
        }

    }
}

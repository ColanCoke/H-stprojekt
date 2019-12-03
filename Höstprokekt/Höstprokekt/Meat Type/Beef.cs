using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Höstprokekt
{
    class Beef : Meat
    {
        Beef()
        {
            savoury = 10;

            fit = "beef"; //köttet beef kommer ha samma namn på "fit". en metod i main kommer avkolla om det står samma sak i "fit"

            vegetarian = false;
        }
    }
}

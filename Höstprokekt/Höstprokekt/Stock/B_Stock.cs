using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Höstprokekt
{
    class B_Stock : Stock //Klass för beef stock som ärver från Stock
    {

        B_Stock() //Konstruktor för Beef stock. Används för att ge den dess stats
        {
            savoury = 10;

            fit = "beef"; //köttet beef kommer ha samma namn på "fit". en metod i main kommer avkolla om det står samma sak i "fit"

            vegetarian = false;
        }

    }
}

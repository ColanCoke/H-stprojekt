using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Höstprokekt
{
    class Meat : Food
    {

        public void Beef()
        {
            savoury = 10;

            fit = "beef"; //köttet beef kommer ha samma namn på "fit". en metod i main kommer avkolla om det står samma sak i "fit"

            price = 50;

            vegetarian = false;
        }

        public void Chicken()
        {
            savoury = 3;

            fit = "chick";

            price = 40;

            vegetarian = false;
        }

        public void Pork()
        {
            savoury = 7;

            fit = "pork";

            price = 25;

            vegetarian = false;
        }

        public void PakChoy()
        {
            savoury = 10;

            fit = "veg";

            price = 20;

            vegetarian = true;
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Höstprokekt
{
    class Stock : Food
    {
        public void Beef()
        {
            savoury = 10;

            fit = "beef"; //köttet beef kommer ha samma namn på "fit". en metod i main kommer avkolla om det står samma sak i "fit"

            price = 30;

            vegetarian = false;
        }

        public void Chicken()
        {
            savoury = 3;

            fit = "chick";

            price = 20;

            vegetarian = false;
        }

        public void Pork()
        {
            savoury = 7;

            fit = "pork";

            price = 25;

            vegetarian = false;
        }

        public void Veggie()
        {
            savoury = 10;

            fit = "veg";

            price = 20;

            vegetarian = true;
        }
    }
}

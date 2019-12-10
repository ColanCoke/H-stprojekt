using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Höstprokekt
{
    public class Stock : Food //En metod för bulljongen som ärver från food
    {

        Random rich = new Random(); //En random generator för richness
        protected int Richness()
        {
            int richness = rich.Next(21);

            return richness;
        }

        public void Beef() //Konstruktor för Beef stock. Används för att ge den dess stats
        {
            savoury = 10;

            fit = "beef"; //köttet beef kommer ha samma namn på "fit". en metod i main kommer avkolla om det står samma sak i "fit"

            vegetarian = false;
        }

        public void Chicken()
        {
            savoury = 3;

            fit = "chick";

            vegetarian = false;
        }

        public void Veggie()
        {
            savoury = 10;

            fit = "veg";

            vegetarian = true;
        }

        public void Pork()
        {
            savoury = 7;

            fit = "pork";

            vegetarian = false;
        }

    }
}

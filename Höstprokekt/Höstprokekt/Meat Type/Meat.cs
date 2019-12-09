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
         
        public void Beef()
        {
            savoury = 10;

            fit = "beef"; //köttet beef kommer ha samma namn på "fit". en metod i main kommer avkolla om det står samma sak i "fit"

            vegetarian = false;
        }

        public void Pak_Choy()
        {
            savoury = 10;

            fit = "veg";

            vegetarian = true;
        }
    }
}

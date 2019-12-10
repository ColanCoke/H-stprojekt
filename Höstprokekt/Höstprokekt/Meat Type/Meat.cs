using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Höstprokekt
{
    public class Meat : Food //en metod för kött som ärver från food
    {
        Random burning = new Random(); //en random generator för att kolla om köttet blev bränt under kokning
        public bool Burnt() //en bool-metod för att se om köttet blev bränt
        {
            if (burning.Next(10) <= 3) //om burning är mindre än/lika med 3 kommer burnt bli true
            {
                return true;
            }

            return false; //om burning är högre än 3 kommer köttet inte vara bränt.
        }
         
        public void Beef()
        {
            savoury = 10; //kollar hur savoury det är.

            fit = "beef"; //köttet beef kommer ha samma namn på "fit". en metod i main kommer avkolla om det står samma sak i "fit"

            vegetarian = false; //en bool för att kolla av om rätten är vegetarian-safe

            name = "Beef";
        }

        public void Chicken()
        {
            savoury = 3;

            fit = "chick";

            vegetarian = false;

            name = "Chicken";
        }

        public void Pak_Choy()
        {
            savoury = 10;

            fit = "veg";

            vegetarian = true;

            name = "Pak choy";
        }

        public void Pork()
        {
            savoury = 7;

            fit = "pork";

            vegetarian = false;

            name = "Pork";
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Höstprokekt
{
    public class Food
    {

        protected int savoury; //Int för savoury of dish. de är protected så andra klasser kan använda dem, men inte "synas".

        protected string fit; //string för fit. Kommer ha en metod för att kolla att bulljongen och köttet passar ihop.

        protected bool vegetarian;

        
        public void Print_Stats()
        {
            Console.WriteLine("Savoury: " + savoury);
            Console.WriteLine("Will fit with: " + fit);
            Console.WriteLine("Vegetarian: " + vegetarian);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Höstprokekt
{
    public class Food //en stor Food klass som alla mattyper är baserade på
    {

        protected int savoury; //Int för savoury of dish. de är protected så andra klasser kan använda dem, men inte "synas".

        public string fit; //string för fit. Kommer ha en metod för att kolla att bulljongen och köttet passar ihop.

        protected bool vegetarian;

        
        public void Print_Stats() //en print-stats metod för att se vad de olika statsen är.
        {
            Console.WriteLine("Savoury: " + savoury);
            Console.WriteLine("Will fit with: " + fit);
            Console.WriteLine("Vegetarian: " + vegetarian);
        }
    }
}

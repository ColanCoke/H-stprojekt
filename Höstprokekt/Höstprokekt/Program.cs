using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Höstprokekt
{
    class Program
    {
        static void Main(string[] args)
        {

            //Skriv i main om slut:
            //If Savory > 15
            // As the soup trickles down your throat, you get a filling feeling in your stomach. Gosh this is savory!
            //Etc.

            Meat m1 = new Meat();
            Console.WriteLine("Choose your meat.");
            Console.WriteLine("1. Beef , 2. Pak Choy");

            string choice;
            choice = Console.ReadLine();
        

            if(choice = "Beef")
            {
                m1.Beef();

            }
            else if (choice = "Pak")
            {
                m1.Pak_Choy();

            }

            m1.Print_Stats();



            //Welcome to game
            //You'll do X and X
            //Start!
            //Choose your stock:
            //Choose your Noodles
            //Choose your Meat:
            //Choose your Garnish:
            //countar ihop de olika värdena. Olika värden ger olika slutdialoger
            
            

            Console.ReadLine();


        }
    }
}

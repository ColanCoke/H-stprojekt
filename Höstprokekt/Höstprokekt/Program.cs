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

            Console.WriteLine("Welcome to Noodle Creator! Create your perfect noodle bowl!");
            System.Threading.Thread.Sleep(600);
            Console.WriteLine("You will get to choose stock base, meat, noodles and garnish!");
            System.Threading.Thread.Sleep(600);
            Console.WriteLine("Remember that certain stocks taste better with certain meat....");
            System.Threading.Thread.Sleep(600);
            Console.WriteLine("Ready?");
            AnyKey();

            //Skriv i main om slut:
            //If Savory > 15
            // As the soup trickles down your throat, you get a filling feeling in your stomach. Gosh this is savory!
            //Etc.



            Meat m1 = new Meat(); //en instans av meat
            Console.WriteLine("Choose your meat.");
            Console.WriteLine("1. Beef , 2. Pak Choy");

            string choice;
            choice = Console.ReadLine();
        

            if(choice == "Beef") //en if-metod som kollar av vad spelaren valt för protein-alternativ.
            {
                m1.Beef(); //om spelaren valt tex beef kommer instansen av meat (m1) få statsen av beef vilket kan användas senare i programmet

            }
            else if (choice == "Pak")
            {
                m1.Pak_Choy();

            }

            m1.Print_Stats();

            AnyKey();

            Stock s1 = new Stock();

            Console.WriteLine("Choose your stock.");
            Console.WriteLine("1. Beef , 2. Vegetable");
            
            string choice2;
            choice2 = Console.ReadLine();


            if (choice2 == "Beef")
            {
                s1.Beef();

            }
            else if (choice2 == "Pak")
            {
                s1.Veggie();

            }

            

            //Welcome to game
            //You'll do X and X
            //Start!
            //Choose your stock:
            //Choose your Noodles
            //Choose your Meat:
            //Choose your Garnish:
            //countar ihop de olika värdena. Olika värden ger olika slutdialoger


            if (m1.fit == s1.fit) //kollar så att fit på stock och meat är samma.
            {
                Console.WriteLine("Yay de passar");
            }
            else
            {
                Console.WriteLine("Passar inte!");
            }

            Console.ReadLine();


        }

        static void AnyKey() //simpel metod för att rensa konsollen
        {
            Console.WriteLine("-->Press Any Key<--");
            Console.ReadKey();
            Console.Clear();
        }
    }
}

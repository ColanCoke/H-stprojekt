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

            Stock s1 = new Stock();
            Console.WriteLine("First of all! Choose your stock! Write the corresponding number between 1-4.");
            Console.WriteLine("1. Beef stock");
            Console.WriteLine("2. Chicken stock");
            Console.WriteLine("3. Vegetable stock");
            Console.WriteLine("4. Pork stock");

            int choice1 = Choice();

            if (choice1 == 1) //en if-metod som kollar av vad spelaren valt för protein-alternativ.
            {
                s1.Beef(); //om spelaren valt tex beef kommer instansen av meat (m1) få statsen av beef vilket kan användas senare i programmet
            }
            else if (choice1 == 2)
            {
                s1.Chicken();
            }
            else if (choice1 == 3)
            {
                s1.Veggie();
            }
            else if (choice1 == 4)
            {
                s1.Pork();
            }

            Console.WriteLine("Great choice! You chose:");
            s1.Get_Name();

            AnyKey();

            Meat m1 = new Meat(); //en instans av meat
            Console.WriteLine("Choose your meat. Write the corresponding number between 1-4.");
            Console.WriteLine("1. Beef");
            Console.WriteLine("2. Chicken");
            Console.WriteLine("3. Pak Choy");
            Console.WriteLine("4. Pork");

            int choice2 = Choice();

            if(choice2 == 1) //en if-metod som kollar av vad spelaren valt för protein-alternativ.
            {
                m1.Beef(); //om spelaren valt tex beef kommer instansen av meat (m1) få statsen av beef vilket kan användas senare i programmet
            }
            else if (choice2 == 2)
            {
                m1.Chicken();
            }
            else if (choice2 == 3)
            {
                m1.Pak_Choy();
            }
            else if (choice2 == 4)
            {
                m1.Pork();
            }

            m1.Print_Stats();

            AnyKey();


            if (m1.fit == s1.fit) //kollar så att fit på stock och meat är samma.
            {
                Console.WriteLine("Yay de passar");
            }
            else
            {
                Console.WriteLine("Passar inte!");
            }

            Console.ReadLine();

            //Skriv i main om slut:
            //If Savory > 15
            // As the soup trickles down your throat, you get a filling feeling in your stomach. Gosh this is savory!
            //Etc.
            //Welcome to game
            //You'll do X and X
            //Start!
            //Choose your stock:
            //Choose your Noodles
            //Choose your Meat:
            //Choose your Garnish:
            //countar ihop de olika värdena. Olika värden ger olika slutdialoger
        }

        static int Choice()
        {
            string writtenChoice = Console.ReadLine();//Gör en string för val av spel
            int choice = 0; //gör en int för val av spel
            int.TryParse(writtenChoice, out choice);//en konvertering så spelaren kan skriva in sitt val av spel som en string som sedan registreras som en int
            bool success = int.TryParse(writtenChoice, out choice); //Gör en string (game)som ska konverteras till en int(GC=Game Choice) med en bool för att se till att konverteringen fungerade.

            while (success == false || choice != 1 && choice != 2 && choice != 3 && choice != 4) //förhindrar spelaren från att skriva in ett icke-fungerande nummer/siffro.
            {

                Console.WriteLine("Please only use letter 1-4.");

                writtenChoice = Console.ReadLine();
                choice = 0;
                success = int.TryParse(writtenChoice, out choice);
            }

            if (choice == 1)
            {
                return 1;
            }
            else if (choice == 2)
            {
                return 2;
            }
            else if (choice == 3)
            {
                return 3;
            }
            else if (choice == 4)
            {
                return 4;
            }

            return 0;
        }

        static void AnyKey() //simpel metod för att rensa konsollen
        {
            Console.WriteLine("-->Press Any Key<--");
            Console.ReadKey();
            Console.Clear();
        }
    }
}

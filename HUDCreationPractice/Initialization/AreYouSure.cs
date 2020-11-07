using HUDCreationPractice.Kosmos;
using System;
using System.Collections.Generic;
using System.Text;

namespace HUDCreationPractice.Initialization
{
    //Called from StartNewGame.cs
    class AreYouSure
    {
        public void Run()
        {
 //Console.WriteLine("Yo from AYS().Run();");
            bool quit;
            do
            {
                Console.Clear();
                Console.WriteLine("Starting a new game will lose all your progress...\n");
                Console.WriteLine("Are you sure you wish to continue?");
                Console.WriteLine("\n                       - (Y)ES -                \n");
                Console.WriteLine("\n                        - (N)O -                \n");
                var key = continueSelect();
                quit = UserChoice(key);
            } while (!quit);
 //Console.WriteLine("Yo from AYS().Run();");
        }
        private ConsoleKey continueSelect() 
        {
            return Console.ReadKey().Key;
        }
        public bool UserChoice(ConsoleKey key)
        {
            switch(key)
            {
                case ConsoleKey.Y:  //continue
                    Console.WriteLine("Yes?");
                    if(Continue())
                    {
                        new CharacterStatGenerator().Run();
                        new Cosmogony().Run();
                    }
                    //currently returns to main menu
                    return true;
                    //break;

                case ConsoleKey.N:
                    Console.Clear();
                    Console.WriteLine("No?  Returning to main menu...");
                    Console.WriteLine("Press any key to continue.");
                    Console.ReadKey();
                    return true;
                    //break;
            }
            return false;//handles keys other than valid options
        }
        public bool Continue()
        {
            do
            {
                Console.Clear();
                Console.WriteLine("WARNING");
                Console.WriteLine("WARNING");
                Console.WriteLine("CATASTROPHIC DATA LOSS MAY OCCUR");
                Console.WriteLine("Are you sure you wish to continue...?");
                Console.WriteLine("Enter YES or NO");
                string key = Console.ReadLine();
                switch (key)
                {
                    case "YES":
                        return true;
                    case "NO":
                        return false;
                }
            } while (true) ;
        }
    }
}

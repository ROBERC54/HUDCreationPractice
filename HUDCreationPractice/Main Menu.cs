using HUDCreationPractice.Initialization;
using System;
using System.Collections.Generic;
using System.Text;

namespace HUDCreationPractice
{
    //Called from APP.cs
    class Main_Menu
    {
        public void Run()
        {
            bool quit = true;
            do
            {
                Console.WriteLine("Yo from MM().Run();");
                Console.Clear();
                Console.WriteLine("\n                       - (B)BEGIN -                \n");
                Console.WriteLine("\n                      - (R)RESUME -                \n");
                Console.WriteLine("\n                      - (H)HOW TO -                \n");
                Console.WriteLine("\n                       - (S)SETTINGS -                \n");
                Console.WriteLine("\n                       - (Q)QUIT -                \n");
                var key = mainMenuSelect();
                quit = UserChoice(key);
            } while (!quit);
        }

        private object mainMenuSelect()
        {
            //UserInput();
            //ConsoleKey key = Console.ReadKey().Key; return key;
            return Console.ReadKey().Key;
        }

        private bool UserChoice(object key)
        {
            switch (key)
            {
                case ConsoleKey.B:
                    new StartNewGame().Run();
                    break;
                case ConsoleKey.R:
                    Resume();
                    break;
                case ConsoleKey.H:
                    How_To();
                    break;
                case ConsoleKey.S:
                    Settings();
                    break;
                case ConsoleKey.Q:
                    return true;
            }
            return false;
        }
        private void Start()
        {
            Console.Clear();
            Console.WriteLine("Start...");
            Console.WriteLine("Press any key to continue");
            Console.ReadKey();
        }
        private void Resume()
        {
            Console.Clear();
            Console.WriteLine("Continue...");
            Console.WriteLine("Press any key to continue");
            Console.ReadKey();
        }
        private void How_To()
        {
            Console.Clear();
            Console.WriteLine("These are the instructions:");
            Console.WriteLine("Press any key to continue");
            Console.ReadKey();
        }
        private void Settings()
        {
            Console.Clear();
            Console.WriteLine("These are the instructionsi dont know wgat to put here:");
            Console.WriteLine("Press any key to continue");
            Console.ReadKey();
        }
    }
}

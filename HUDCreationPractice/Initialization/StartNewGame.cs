using HUDCreationPractice.Kosmos;
using System;
using System.Collections.Generic;
using System.Text;

namespace HUDCreationPractice.Initialization
{
    //Called from Main_Menu.cs
    public class StartNewGame
    {//From the MainMenu screen, functionality results from whether the User selects "Play Game", "Resume", "How to", or "Quit."
     //This class will handle the case of "Play Game" when called from within Main_Menu.cs
     //The class functions to start the game off and introduce the character.  It should save progress by the end of the sequence and pass to "Resume.cs"
        public void Run() 
        {
//Console.WriteLine("Yo from SNG().Run();");
            new AreYouSure().Run();
            new Cosmogony().Run();
//Console.WriteLine("Yo from SNG().Run();");
        }
    }
}

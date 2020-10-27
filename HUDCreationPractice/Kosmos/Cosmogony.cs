using HUDCreationPractice.Initialization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HUDCreationPractice.Kosmos
{
    //Called from Main_Menu.cs
    //Called from AreYouSure.cs
    class Cosmogony
    {
        List<List<string>> Characters;
        List<List<string>> tempCharacters;
        List<string> protagonist;
        List<string> tempProtagonist;
        Character charObject;
        public Cosmogony() 
        {

        }
        public void Run() 
        {
            //Cosmogony World = new Cosmogony();
            charObject = new Character();
            (Characters, tempCharacters) = charObject.getChars();
            protagonist = Characters.ElementAt(0);
            tempProtagonist = tempCharacters.ElementAt(0);
            new HUD().Run(protagonist, tempProtagonist);
            foreach(string list in protagonist) 
            {
                Console.WriteLine(list);
            }
            Console.WriteLine("yiightyeet");
            Console.ReadKey();
        }
    }
}

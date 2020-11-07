using HUDCreationPractice.Initialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace HUDCreationPractice.Kosmos
{
    //Called from Cosmogony
    class Character
    {
        List<string> bodies = File.ReadAllLines("Characters.txt").ToList();

        List<List<string>> Characters;
        List<List<string>> tempCharacters;
        List<string> body;
        List<string> tempBody;
        //string statSheet = " Stat Sheet.txt";
        public Character() 
        { }
        public void Run() 
        {
            Characters = new List<List<string>>();
            tempCharacters = new List<List<string>>();
            foreach (string name in bodies)
            {
                body = (File.ReadAllLines($"{name} Stat Sheet.txt").ToList());
                tempBody = (File.ReadAllLines($"{name} Temp Sheet.txt").ToList());
                Characters.Add(body);
                tempCharacters.Add(tempBody);
                //Console.ReadKey();

                //new CharacterStatGenerator().readItBack(name);
                //Characters.Add(File.ReadAllLines($"{name} Stat Sheet.txt").ToList());
            }
            //body = File.ReadAllLines(statSheet).ToList();
        }
        public (List<List<string>>, List<List<string>>) getChars()
        {
            Run();
            return (Characters, tempCharacters);
        }
        public string getProtagonist() 
        {
            return bodies.ElementAt(0);
        }
    }
}

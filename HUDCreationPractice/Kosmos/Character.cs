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
        List<string> body;
        string statSheet = " Stat Sheet.txt";
        public Character() 
        { }
        public void Run() 
        {
            foreach (string name in bodies)
            {
                Console.Clear();
                Console.WriteLine("Yo from character");
                Console.WriteLine("PAKTC");
                Console.ReadKey();
                Characters.Add(File.ReadAllLines($"{name}{statSheet}").ToList());
                //new CharacterStatGenerator().readItBack(name);
                //Characters.Add(File.ReadAllLines($"{name} Stat Sheet.txt").ToList());
            }
            //body = File.ReadAllLines(statSheet).ToList();
        }
        public List<List<string>> getChars()
        {
            Run();
            return Characters;
        }
    }
}

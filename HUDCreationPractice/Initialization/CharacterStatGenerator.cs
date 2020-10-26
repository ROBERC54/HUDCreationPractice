using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace HUDCreationPractice.Initialization
{
    //Called from AreYouSure.cs
    class CharacterStatGenerator
    {
        List<string> readback;
        string characterName;
        string statSheet;
        List<string> preppedTable;
        public void Run() 
        {
//Console.WriteLine("Yo from CSG().Run();");
            Console.Clear();
            Console.WriteLine("What is your name?");
            characterName = Console.ReadLine();
            prepTable();
            runStatSheet();
            runTempSheet();

            readItBack();
//Console.WriteLine("Yo from CSG().Run();");
        }
        public void runStatSheet() 
        {
            statSheet = $"{characterName} Stat Sheet.txt";
            List<string> info = new List<string>();
            info.Add("18");//Age
            info.Add(characterName);
            info.Add("328");//HP
            info.Add("20");//MP
            info.Add("100");//STM
            info.Add("31");//ATK
            info.Add("45");//UDF
            info.Add("49");//LDF
            info.Add("49");//SPD
            info.Add("25");//INT
            info.Add("73");//AGL
            info.Add("");//
            File.WriteAllLines(statSheet, info);
        }
        public void runTempSheet() 
        {
            string tempSheet = $"{characterName} Temp Sheet.txt";
            List<string> tempStatInfo = new List<string>();
            tempStatInfo.Add("328");//MaxHP
            tempStatInfo.Add("328");//CurrentHP
            tempStatInfo.Add("20");//MP
            tempStatInfo.Add("20");//CurrentMP
            tempStatInfo.Add("100");//Stamina
            tempStatInfo.Add("100");//CurrentStamina
            tempStatInfo.Add("");//
            File.WriteAllLines(tempSheet, tempStatInfo);
        }
        public void readItBack() 
        {
            //want to read it back?
            Console.Clear();
            readback = File.ReadAllLines(statSheet).ToList();
            Console.WriteLine("Character Info");
            int i = 0;
            List<string> chart = new List<string>();
            foreach (string line in readback)
            {
                Console.WriteLine($"{preppedTable.ElementAt(i)}{line}");
                i++;
            }

            Console.WriteLine("PAKTC");
            Console.ReadKey();
            Console.Clear();
        }
        public void prepTable() 
        {
            List<string> characters = new List<string>();
            characters.Add(characterName);
            File.WriteAllLines("Characters.txt", characters);
            List<string> chart = new List<string>();
            chart.Add("Age: ");
            chart.Add("Name: ");
            chart.Add("HP:  ");
            chart.Add("MP:  ");
            chart.Add("STM: ");
            chart.Add("ATK: ");
            chart.Add("UDF: ");
            chart.Add("LDF: ");
            chart.Add("SPD: ");
            chart.Add("INT: ");
            chart.Add("AGL: ");
            chart.Add("");
            preppedTable = chart;
        }
    }
}
//For reference,    Vera1->102  20 30  44  48  48  24  72  EXP90   G31  ElAffin Fir Win LigSTR Thu Wat Ear DarWEA Bloodsucker ABsRate 60%
//                  Vera2->279  40 72  98  120 68  52  85  EXP248  G80  Same BluABsRate 60% Heal
//                  Vera3->1486 90 155 270 400 235 271 118 EXP2808 G975 Same BluABsRate 70% Heal
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HUDCreationPractice.Kosmos
{
    //Called from Cosmogony.cs
    class HUD
    {
        int HP;
        int cHP;
        int MP;
        int cMP;
        int STM;
        int cSTM;
        double barHP,  fullHP,  numExtraHPbars;
        double barMP,  fullMP,  numExtraMPbars;
        double barSTM, fullSTM, numExtraSTMbars;
        public void Run(List<string> protagonist, List<string> tempProtagonist)    
        {//remember it's Age, name, 2HP, MP, STM, 5ATK, UDF, LDF, 8SPD, INT, AGL
            //maxHP,HP,maxMP,MP,maxSTM,STM
            Console.Clear();
            Console.WriteLine("HUD");
            int.TryParse(protagonist.ElementAt(2), out HP);
            int.TryParse(tempProtagonist.ElementAt(1), out cHP);
            int.TryParse(protagonist.ElementAt(3), out MP);
            int.TryParse(tempProtagonist.ElementAt(3), out cMP);
            int.TryParse(protagonist.ElementAt(4), out STM);
            int.TryParse(tempProtagonist.ElementAt(5), out cSTM);
            setUp();
            Console.WriteLine($"{cHP}/{HP}||||||||||||||||||||||||||||||||||||||||||||||||||");
            Console.WriteLine($"{cMP}/{MP}||||||||||||||||||||||||||||||||||||||||||||||||||");
            Console.WriteLine($"{cSTM}/{STM}||||||||||||||||||||||||||||||||||||||||||||||||||");
            Console.WriteLine("yhilightyeet");
            Console.WriteLine("PAKTC");
            Console.ReadKey();
        }
        public void setUp()
        {
            numExtraHPbars = 0;
            numExtraMPbars = 0;
            numExtraSTMbars = 0;
            (fullHP, numExtraHPbars) = runBar(HP, fullHP, numExtraHPbars);
            (fullMP, numExtraMPbars) = runBar(MP, fullMP, numExtraMPbars);
            (fullSTM, numExtraSTMbars) = runBar(STM, fullSTM, numExtraSTMbars);
            barHP = 50*cHP / HP;
            barMP = 50*cMP / MP;
            barSTM = 50*cSTM / STM;
            int bleh = cHP / HP;
        }
        public (double, double) runBar(int max, double full, double numExtra) 
        {
            if (max > 49)
            {
                full = 50;
                int i = max;
                for (; (i / 10000) >= 100;)
                {
                    i -= 1000000;
                    numExtra += 20000;
                }
                for (; (i / 10000) >= 10;)
                {
                    i -= 100000;
                    numExtra += 2000;
                }
                for (; (i / 10000) >= 1;)
                {
                    i -= 10000;
                    numExtra += 200;
                }
                for (; (i / 1000) >= 1;)
                {
                    i -= 1000;
                    numExtra += 20;
                }
                for (; i > 99;)
                {
                    i -= 100;
                    numExtra += 2;
                }
                if (i > 49)
                { i -= 50;
                    numExtra += 1;
                }
            }
            else { full = max; }
            return (full, numExtra);
        }
    }
}

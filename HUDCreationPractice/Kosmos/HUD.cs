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
            Console.Write("HUD");
            int.TryParse(protagonist.ElementAt(2), out HP);
            int.TryParse(tempProtagonist.ElementAt(1), out cHP);
            int.TryParse(protagonist.ElementAt(3), out MP);
            int.TryParse(tempProtagonist.ElementAt(3), out cMP);
            int.TryParse(protagonist.ElementAt(4), out STM);
            int.TryParse(tempProtagonist.ElementAt(5), out cSTM);
            setUp();
            Console.WriteLine("");//display was not a cwTABTAB
            Console.WriteLine("yhilightyeetfrom HUD");
            Console.WriteLine("PAKTC");
            Console.ReadKey();
        }
        public void setUp()
        {
            numExtraHPbars = 0;
            numExtraMPbars = 0;
            numExtraSTMbars = 0;
            (barHP, fullHP, numExtraHPbars) = runBar(HP, fullHP, numExtraHPbars);
            (barMP, fullMP, numExtraMPbars) = runBar(MP, fullMP, numExtraMPbars);
            (barSTM, fullSTM, numExtraSTMbars) = runBar(STM, fullSTM, numExtraSTMbars);
            barHP = 50*cHP / HP;//bars were just set in the event I want to transition to using a renegade sroth system*<z
            barMP = 50*cMP / MP;//this will require small reworks to display should you choose to come back and instate
            barSTM = 50*cSTM / STM;
            display(barHP, cHP, HP);
            display(barMP, cMP, MP);
            display(barSTM, cSTM, STM);
        }
        public (double, double, double) runBar(int max, double full, double numExtra) 
        {
                double i = max;
            if (max > 49)
            {
                full = 50;//small reworks are in order if you wish to display more than 50 ticks
                for (; (i / 10000) >= 1000;)
                {
                    i -= 10000000;
                    numExtra += 200000;
                }
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
            return (i, full, numExtra);
        }
        public void display(double barN, int cN, int mN)
        { 
            Console.Write($"\n{cN}/{mN}");
            for (int i=0; i<barN; i++)
            {
                Console.Write("|");
            }
            for (double i = barN; i < 50; i++)
            {
                Console.Write("!");
            }
        }
    }
}

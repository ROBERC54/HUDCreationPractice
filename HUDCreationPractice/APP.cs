using System;
using System.Collections.Generic;
using System.Text;

namespace HUDCreationPractice
{
    //Called from Program.cs
    class APP
    {
        public void Run()
        {
            Console.WriteLine("Yo from the APP");
            int bleh = 50*327 / 328;
            double blehh = 50*327 / 328;
            Console.WriteLine(bleh);
            Console.WriteLine(blehh);
            Console.ReadKey();
            new Main_Menu().Run();
            Console.Clear();
            Console.WriteLine("Yo from the APP");
        }
    }
}

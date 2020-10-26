using HUDCreationPractice.Initialization;
using System;
using System.Collections.Generic;
using System.Text;

namespace HUDCreationPractice.Kosmos
{
    //Called from StartNewGame.cs
    class Cosmogony
    {

        public Cosmogony() 
        {

        }
        public void Run() 
        {
            Cosmogony World = new Cosmogony();
            Console.WriteLine("Yo from Cosmo");
            Console.WriteLine("PAKTC");
            Console.ReadKey();
            new Character().Run();
        }
    }
}

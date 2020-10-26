using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace HUDCreationPractice.Kosmos
{
    class Character
    {
        List<string> body;
        string statSheet = "";
        public void Run() 
        {
            body = File.ReadAllLines(statSheet).ToList();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace HomeWork.Delegate.HunterAndHare
{
    class Hunter
    {
        public delegate void Moved(Hare ha);
        public string Name { get; } 
        public Hunter(string name)

        {
            Name = name;
        }
        public void SendMessage(Hare hare)
        {
            Console.WriteLine(Name+"---"+hare.Name + ": " + hare.X.ToString() + "/" + hare.Y.ToString());
        }
    }

}

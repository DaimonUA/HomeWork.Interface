using System;
using System.Collections.Generic;
using System.Text;

namespace HomeWork.Delegate.HunterAndHare
{
    class Hunter
    {
        public string name;
        public delegate void Moved(Hare ha);
        public string Name { get; }
        public Hunter(string name)

        {
            Name = name;
            this.name = name;
        }
        //реализация анономного метода
        public Moved dlampda = (Hare m)=> Console.WriteLine("--лямпда выражение--" + m.Name + ": " + m.X.ToString() + "/" + m.Y.ToString());
        public Moved d = delegate (Hare m)
        {
            //Console.WriteLine(name+ "---" + m.Name + ": " + m.X.ToString() + "/" + m.Y.ToString());
            Console.WriteLine("--анонимный метод--" + m.Name + ": " + m.X.ToString() + "/" + m.Y.ToString());
        };
        public void SendMessage(Hare hare)
        {
            Console.WriteLine(Name+"--делегат через событие-"+hare.Name + ": " + hare.X.ToString() + "/" + hare.Y.ToString());
        }
    }

}

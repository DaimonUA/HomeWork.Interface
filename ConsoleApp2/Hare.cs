using System;
using System.Collections.Generic;
using System.Text;

namespace HomeWork.Delegate.HunterAndHare
{
    class Hare
    {
        private int x;
        private int y;
        public event Hunter.Moved Moveding;
        public int X { get; private set; }
        public int Y { get; private set; }
        public string Name { get; private set; }
        public Hare(string name)
        {
            Name = name;

            Move();
        }

        public void Move()
        {
            Random rnd = new Random();
            x = rnd.Next(100);
            y = rnd.Next(100);
            X = x;
            Y = y;
            if (Moveding != null)
            {
                //Console.WriteLine("Координаты зайца: %1 %2",x,y);
                Moveding(this);
            }
        }
    }
}

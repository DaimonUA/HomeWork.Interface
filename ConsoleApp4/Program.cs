using System;

namespace HomeWork.Interface
{
    partial class Program
    {
        static void Main(string[] args)
        {
            Lamp l = new Lamp(10);
            Console.WriteLine(l.ToString());
            l.On();

            Console.WriteLine(l.ToString());

            Console.WriteLine(l["state"]);
            Console.WriteLine(l["type"]);

            l.Off();
            l.State = true;
            Console.WriteLine(l.ToString());

            Console.WriteLine(l[0]);
            Console.WriteLine(l[1]);
            Console.WriteLine(l["выфвыйфыв"]);

            l.AnyProperties = null;
            Console.WriteLine(l.AnyProperties);

            //Lamp l2 = new TempLamp(5);

        }
    }
}

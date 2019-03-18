using System;
using System.Collections.Generic;
using System.Text;

namespace HomeWork.Interface
{
    public class Lamp : Device
    {
        public string this[int ind] //индексатор свойств по индексу числовому
        {
            get
            {
                string res;
                switch (ind)
                {
                    case 0: res = (string)Type; break;
                    case 1: res = State.ToString(); break;
                    default: res = res = Number.ToString(); break;
                }

                return res;
             }
        }
        public string this[string strInd] //индексатор свойств по индексу строчному (перегрузка)
        {
            get
            {
                string res;
                switch (strInd)
                {
                    case "type":res = (string)Type; break;
                    case "state": res = State.ToString(); break;
                    default: res = Number.ToString(); break;
                }

                return res;
            }
        }

        public override string Type
        {
            get { return "the lamp"; }
        }

        public override bool State { get ; set; }

        public Lamp(int num)
        {
            Number = num;
        }

        public Lamp()
        {
            Number++;
        }

        public override void Off()
        {
            State = false;
        }

        public override void On()
        {
            State = true;
        }
    }
}

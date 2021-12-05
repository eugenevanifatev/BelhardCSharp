using System;
using System.Collections.Generic;
using System.Text;

namespace Unit4
{
    internal struct Case6
    {
        public int number;
        public bool action;

        public Case6(int number) { action = true; this.number = number; }
        public Case6(bool action, int number) { this.action = action; this.number = number; }

        public void GetInfo()
        {
            Console.WriteLine("Metod \"DoMultiplication\" return number * 2 if action is true.");
        }

        public int DoMultiplication()
        {
            if (action)
            {
                return number * 2;
            }
            else
            {
                return number;
            }
        }
    }
}

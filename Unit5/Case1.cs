using System;
using System.Collections.Generic;
using System.Text;

namespace Unit5
{
    internal class Case1
    {
        public int Number { get; set; }
        public bool Action { get; set; }

        public Case1() { Action = true; Number = 5; }
        public Case1(int number) { Action = true; this.Number = number; }
        public Case1(bool action, int number) { this.Action = action; this.Number = number; }

        public void GetInfo()
        {
            Console.WriteLine("Metod \"DoMultiplication\" return number * 2 if action is true.");
        }

        public int DoMultiplication()
        {
            if (Action)
            {
                return Number * 2;
            }
            else
            {
                return Number;
            }
        }
    }
}

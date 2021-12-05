using System;

namespace Unit5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Case1 case1 = new Case1();
            case1.GetInfo();
            case1.Action = false;
            case1.Number = 10;
            Console.WriteLine(case1.DoMultiplication());
        }
    }
}

using System;

namespace Unit4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Case2 case2 = new Case2();
            //case2.GetCalculator();

            Case4Case5 case4_1 = new Case4Case5(true, 5);
            case4_1.GetInfo();
            Console.WriteLine(case4_1.DoMultiplication());

            Case4Case5 case4_2 = new Case4Case5();
            case4_2.number = 5;
            case4_2.action = false;
            case4_2.GetInfo();
            Console.WriteLine(case4_2.DoMultiplication());

            Case6 case6 = new Case6(false, 15);
            case6.GetInfo();
            Console.WriteLine(case6.DoMultiplication());
        }
    }
}

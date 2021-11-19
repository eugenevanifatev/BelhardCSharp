using System;

namespace Unit3
{
    class Program
    {
        static void Main(string[] args)
        {
            Case1_1 case1_1 = new Case1_1();
            case1_1.MainMethod();

            Case1_2 case1_2 = new Case1_2();
            case1_2.GetCalculator();

            Case2 case2 = new Case2();
            case2.CallFunctions();

            Case3 case3 = new Case3();
            case3.MainMethod();
        }
    }
}

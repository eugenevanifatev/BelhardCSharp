using System;

namespace Unit4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Case2 case2 = new Case2();
            case2.GetCalculator();

            Case4 case4_1 = new Case4(); 
            case4_1.GetInfo();
            Console.WriteLine(case4_1.DoMultiplication(5, true));

            Case4 case4_2 = new Case4();
            case4_2.GetInfo();
            Console.WriteLine(case4_2.DoMultiplication(5, false));
        }
    }
}

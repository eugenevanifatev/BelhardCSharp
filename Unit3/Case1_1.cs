using System;
using System.Collections.Generic;
using System.Text;

namespace Unit3
{
    //Написать 5 функций (3 с параметрами, 2 без) и вызвать их.
    class Case1_1
    {
        public void MainMethod()
        {
            Method1();
            Console.WriteLine(Method2());
            Console.WriteLine(Method3(5, 7));
            Console.WriteLine(Method4(Convert.ToDouble(Console.ReadLine()), Convert.ToDouble(Console.ReadLine())));
            Console.WriteLine(Method5(false));

            Console.ReadKey();
            Console.Clear();
        }

        void Method1()
        {
            Console.WriteLine("It's Method 1.");
        }

        string Method2()
        {
            return ("It's Method 2.");
        }

        int Method3(int a, int b)
        {
            return (a + b);
        }

        double Method4(double a, double b)
        {
            return (a / b);
        }

        bool Method5(bool a)
        {
            bool b = !a;
            return (b);
        }
    }
}

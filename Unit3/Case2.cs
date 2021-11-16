using System;
using System.Collections.Generic;
using System.Text;

namespace Unit3
{
//    Задание 3.2: 
//1. Написать функцию с необязательными параметрами
//2. Написать функцию с именованными параметрами
//3. Написать функцию с модиф-м ref
//4. Написать функцию с модиф-м out
//5. Написать функцию с модиф-м in
//6. Написать функцию с модиф-м params

    class Case2
    {
        public void CallFunctions()
        {
            GetFunction1();

            GetFunction2(b:1, a:7);

            int number1 = 9;
            GetFunction3(ref number1);
            Console.WriteLine($"Function 3 return: {number1}");

            int number2 = 5;
            int number3;
            GetFunction4(number2, out number3);
            Console.WriteLine($"Function 4 return: {number3}");

            GetFunction5(2, 6);

            GetFunction6(1, 2, 3, 4, 5, 6, 7, 8, 9, 10);
        }

        void GetFunction1(int a=5, int b=7)
        {
            Console.WriteLine($"Function 1 return: {a + b}");
        }

        void GetFunction2(int a, int b)
        {
            Console.WriteLine($"Function 2 return: {a - b}");
        }

        void GetFunction3(ref int a)
        {
            a++;
        }

        void GetFunction4(int a, out int b)
        {
            b = a;
        }

        void GetFunction5(int a, in int b)
        {
            Console.WriteLine($"Function 5 return: {a + b}");
        }

        void GetFunction6(params int[] a)
        {
            int sum = 0;
            foreach (int i in a)
                sum += i;
            Console.WriteLine($"Function 6 return: {sum}");
        }
    }
}

using System;

namespace Unit2
{
    class Program
    {
        static void Main(string[] args)
        {
            Case1();
            Case2();
        }

        //Задание 2.1: 
        //Провести вычисления и вывести результаты в консоль
        //1. Написать калькулятор(исп. switch-case)
        //2. Написать программу для вывода названия месяца по его номеру(исп. switch-case)
        static void Case1()
        {
            Console.WriteLine("1:");
            Console.Write("Enter x: ");
            double x = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter y: ");
            double y = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter sign: ");
            char sign = Convert.ToChar(Console.ReadLine());
            switch (sign)
            {
                case '+':
                    Console.WriteLine(x + " + " + y + " = " + (x + y));
                    break;
                case '-':
                    Console.WriteLine(x + " - " + y + " = " + (x - y));
                    break;
                case '*':
                    Console.WriteLine(x + " * " + y + " = " + (x * y));
                    break;
                case '/':
                    Console.WriteLine(x + " / " + y + " = " + (x / y));
                    break;
                case '%':
                    Console.WriteLine(x + " % " + y + " = " + (x % y));
                    break;
                default:
                    Console.WriteLine("Incorrect sign");
                    break;
            }

            Console.WriteLine("2:");
            Console.Write("Enter the month number: ");
            int month = Convert.ToInt32(Console.ReadLine());
            switch (month)
            {
                case 1:
                    Console.WriteLine("January");
                    break;
                case 2:
                    Console.WriteLine("February");
                    break;
                case 3:
                    Console.WriteLine("March");
                    break;
                case 4:
                    Console.WriteLine("April");
                    break;
                case 5:
                    Console.WriteLine("May");
                    break;
                case 6:
                    Console.WriteLine("June");
                    break;
                case 7:
                    Console.WriteLine("July");
                    break;
                case 8:
                    Console.WriteLine("August");
                    break;
                case 9:
                    Console.WriteLine("September");
                    break;
                case 10:
                    Console.WriteLine("October");
                    break;
                case 11:
                    Console.WriteLine("November");
                    break;
                case 12:
                    Console.WriteLine("December");
                    break;
                default:
                    Console.WriteLine("Incorrect the month number.");
                    break;
            }

            Console.ReadKey();
            Console.Clear();
        }

        //Задание 2.2: 
        //1. Каждый год участок с яблонями увеличивается на 10%. Просчитать итоговую площадь участка за 8 лет, 
        //   если в первый год было 200м.кв. (исп. for)
        //2. Вывести на экран все числа от 0 до 100, которые делятся на 8 без остатка(исп. for)
        static void Case2()
        {
            Console.WriteLine("1:");
            decimal square = 200;
            for (int i = 0; i < 8; i++)
            {
                square = square * 1.1m;
            }
            Console.WriteLine("Total area is " + square);

            Console.WriteLine("2:");
            for (int i = 1; i < 101; i++)
            {
                if (i%8 == 0)
                {
                    Console.Write(i + " ");
                }
            }

            Console.ReadKey();
            Console.Clear();
        }
    }
}

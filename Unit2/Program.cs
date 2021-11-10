using System;

namespace Unit2
{
    class Program
    {
        static void Main(string[] args)
        {
            Case1();
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
    }
}

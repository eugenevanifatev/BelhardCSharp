using System;
using System.Collections.Generic;
using System.Text;

namespace Unit3
{
    //Переделать задание с калькулятором на использование функций (вынести действия калькулятора в отдельные функции)
    class Case1_2
    {
        public void Calculator()
        {
            double number1 = GetNumber();
            double number2 = GetNumber();
            char oper = GetOperator();

            Console.Write($"{number1} {oper} {number2} = ");

            switch (oper)
            {
                case ('+'):
                    ShowSum(number1, number2);
                    break;
                case ('-'):
                    ShowDifference(number1, number2);
                    break;
                case ('*'):
                    ShowMultiplication(number1, number2);
                    break;
                case ('/'):
                    ShowDivision(number1, number2);
                    break;
                default:
                    Console.WriteLine("Error");
                    break;
            }

            Console.ReadKey();
            Console.Clear();
        }

        double GetNumber()
        {
            Console.Write("Enter number: ");
            return(Convert.ToDouble(Console.ReadLine()));
        }

        char GetOperator()
        {
            Console.Write("Enter operator (+ - * /): ");
            return (Convert.ToChar(Console.ReadLine()));
        }

        void ShowSum(double a, double b)
        {
            Console.WriteLine(a + b);
        }

        void ShowDifference(double a, double b)
        {
            Console.WriteLine(a - b);
        }

        void ShowMultiplication(double a, double b)
        {
            Console.WriteLine(a * b);
        }

        void ShowDivision(double a, double b)
        {
            Console.WriteLine(a / b);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace Unit4
{
//    Задание 4.2: 
//Реализовать калькулятор, используя
//enum Operation
//    {
//        Add = 1,
//        Subtract,
//        Multiply,
//        Divide,
//        Mod,  //остаток от деления
//        Factorial,  //факториал числа    
//        Sqrt,  //корень степени
//        Power  //возведение в степень  
//    }
    internal class Case2
    {
        enum Operation
        {
            Add = 1,
            Subtract,
            Multiply,
            Divide,
            Mod,  //остаток от деления
            Factorial,  //факториал числа    
            Sqrt,  //корень степени
            Power  //возведение в степень  
        }

        public void GetCalculator()
        {
            int oper = GetOperator();
            int number1;
            int number2;

            if (oper == (int)Operation.Factorial)
            {
                number1 = GetNumber();
                Console.WriteLine($"Result = {Factorial(number1)}");
            }
            else
            {
                number1 = GetNumber();
                number2 = GetNumber();

                double result = oper switch
                {
                    (int)Operation.Add => Add(number1, number2),
                    (int)Operation.Subtract => Subtract(number1, number2),
                    (int)Operation.Multiply => Multiply(number1, number2),
                    (int)Operation.Divide => Divide(number1, number2),
                    (int)Operation.Mod => Mod(number1, number2),
                    (int)Operation.Power => Power(number1, number2),
                    (int)Operation.Sqrt => Sqrt(number1, number2),
                };

                Console.WriteLine($"Result = {result}");
            }

            Console.ReadKey();
            Console.Clear();
        }

        int GetNumber()
        {
            Console.Write("Enter number: ");

            if(int.TryParse(Console.ReadLine(), out int inputValue) && inputValue >= 0)
            {
                return inputValue;
            }
            else
            {
                Console.WriteLine("Input correct number > 0");
                return GetNumber();
            }
        }

        int GetOperator()
        {
            Console.WriteLine("Enter operator:\n 1 - Add \n 2 - Subtract \n 3 - Multiply \n 4 - Divide " +
                "\n 5 - Mod \n 6 - Factorial \n 7 - Sqrt \n 8 - Power");

            if(int.TryParse(Console.ReadLine(), out int inputValue) && inputValue > 0 && inputValue < 9)
            {
                return inputValue;
            } 
            else
            {
                Console.WriteLine("Incorrect number of operation, please, try again.");
                return GetOperator();
            }
        }

        double Add(int a, int b)
        {
            return (a + b);
        }

        double Subtract(int a, int b)
        {
            return (a - b);
        }

        double Multiply(int a, int b)
        {
            return (a * b);
        }

        double Divide(int a, int b)
        {
            return (a / b);
        }

        double Mod(int a, int b)
        {
            return (a % b);
        }

        double Factorial(int a)
        {
            if (a == 0)
            {
                return 1;
            }
            else
            {
                return a * Factorial(a - 1);
            }
        }

        double Sqrt(int a, int b)
        {
            return (Math.Pow(a, 1 / b));
        }

        double Power(int a, int b)
        {
            return (Math.Pow(a, b));
        }
    }
}

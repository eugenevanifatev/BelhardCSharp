using System;

namespace Unit2
{
    class Program
    {
        static void Main(string[] args)
        {
            Case1();
            Case2();
            Case3();
            Case4();
            Case5();
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

        //Задание 2.3: 
        //1. С клавиатуры вводят числа, прекратить ввод как только введут отрицательное число
        //   и вывести на экран “Ввод окончен” (исп. for и break)
        //2. Пункт 1 (исп. while, do-while)
        static void Case3()
        {
            double n = 0;

            Console.WriteLine("1:");
            for (int i = 0; i < 2; i++)
            {
                n = Convert.ToDouble(Console.ReadLine());
                if (n < 0)
                {
                    Console.WriteLine("The End");
                    break;
                }
                i--;
            }

            Console.WriteLine("2.1:");
            n = 0;
            while (n >= 0)
            {
                n = Convert.ToDouble(Console.ReadLine());
            }
            Console.WriteLine("The End");

            Console.WriteLine("2.2:");
            do
            {
                n = Convert.ToDouble(Console.ReadLine());
            } 
            while (n >= 0);
            Console.WriteLine("The End");

            Console.ReadKey();
            Console.Clear();
        }

        //Задание 2.4: 
        //1. С клавиатуры вводят 10 чисел(оценки за контрольную), проверить сколько детей получили ниже 4 (исп. foreach)
        //2. С клавиатуры вводят 12 чисел, найти среднее арифметическое и среднее геометрическое значения(исп. foreach)
        static void Case4()
        {
            Console.WriteLine("1:");
            int[] marks = new int[10];
            Console.WriteLine("Enter marks of students:");
            for (int i = 0; i < 10; i++)
            {
                int x = i + 1;
                Console.Write($"{x} student: ");
                marks[i] = Convert.ToInt32(Console.ReadLine());
            }
            int n = 0;
            foreach (int i in marks)
            {
                if (i < 4)
                    n++;
            }
            Console.WriteLine($"{n} students have mark less than 4 point.");

            Console.WriteLine("2:");
            double[] numbers = new double[12];
            Console.WriteLine("Enter numbers:");
            for (int i = 0; i < 12; i++)
            {
                int x = i + 1;
                Console.Write($"{x} number: ");
                numbers[i] = Convert.ToDouble(Console.ReadLine());
            }
            double count = 0;
            double sum = 0;
            double mul = 1;
            foreach (double i in numbers)
            {
                count++;
                sum = sum + i;
                mul = mul * i;
            }
            double arithProgr = sum / count;
            double geomProgr = Math.Pow(mul, 1/count);
            Console.WriteLine($"arithmetic progression = {arithProgr} \ngeometric progression = {geomProgr}");

            Console.ReadKey();
            Console.Clear();
        }

        //Задание 2.5: 
        //С клавиатуры вводят 10 чисел(двум-й массив 2х5), вывести на экран номер строки, в которой сумма значений будет наибольшей
        static void Case5()
        {
            int[,] numbers = new int[2, 5];

            int sum = 0;
            int totalSum = 0;
            int numberOfString = 0;

            for (int i =0; i < 2; i++)
            {
                int x = i + 1;
                Console.WriteLine($"{x} string: ");
                for (int j = 0; j < 5; j++)
                {
                    numbers[i, j] = Convert.ToInt32(Console.ReadLine());
                    sum = sum + numbers[i, j];
                }
                if (sum > totalSum)
                {
                    totalSum = sum;
                    numberOfString = i;
                }
                sum = 0;
            }

            Console.WriteLine($"Sum is more in {++numberOfString} string.");

            Console.ReadKey();
            Console.Clear();
        }

    }
}

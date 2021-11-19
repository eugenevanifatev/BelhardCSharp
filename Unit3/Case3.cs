using System;
using System.Collections.Generic;
using System.Text;

namespace Unit3
{
//    Задание 3.3: 
//1. Реализовать явное(4 типа) и неявное(4 типа) преобразования
//2. Реализовать приведение 4 типов(исп.Parse и TryParse)
//3. Реализовать приведение 4 типов(исп.Convert)

    class Case3
    {
        public void MainMethod()
        {
            GetSubtask1();
            GetSubtask2();
            GetSubtask3();

            Console.ReadKey();
            Console.Clear();
        }

        void GetSubtask1()
        {
            Console.WriteLine("Subtask 1:");

            byte a1 = 4;
            short a2 = a1;
            int a3 = a2;
            long a4 = a3;
            double a5 = a4;

            decimal b1 = 55555555555555.999m;
            long b2 = (long)b1;
            int b3 = (int)b2;
            short b4 = (short)b3;
            byte b5 = (byte)b4;

            Console.WriteLine($"Implicit conversion: {a1} -> {a2} -> {a3} -> {a4} -> {a5}");
            Console.WriteLine($"Explicit conversion: {b1} -> {b2} -> {b3} -> {b4} -> {b5}");
        }

        void GetSubtask2()
        {
            Console.WriteLine("Subtask 2:");

            bool a1 = bool.Parse("true");
            int a2 = int.Parse("2");
            double a3 = double.Parse("3,4");
            char a4 = char.Parse("4");

            int b1;
            if (!int.TryParse(Console.ReadLine(), out b1))
                {
                    Console.WriteLine("Incorrect value");
                }
            
            bool b2;
            if (!bool.TryParse(Console.ReadLine(), out b2))
            {
                Console.WriteLine("Incorrect value");
            }

            char b3;
            if (!char.TryParse(Console.ReadLine(), out b3))
            {
                Console.WriteLine("Incorrect value");
            }

            double b4;
            if(!double.TryParse(Console.ReadLine(), out b4))
            {
                Console.WriteLine("Incorrect value");
            }
        }

        void GetSubtask3()
        {
            Console.WriteLine("Subtask 3:");

            int a1 = Convert.ToInt32(Console.ReadLine());
            char a2 = Convert.ToChar(Console.ReadLine());
            double a3 = Convert.ToDouble(Console.ReadLine());
            bool a4 = Convert.ToBoolean(Console.ReadLine());
        }
    }
}

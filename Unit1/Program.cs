using System;

namespace Unit1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Case3();
            Case4();
            Console.ReadLine();
        }

        //Задание 1.3: 
        //Определите переменные всех возможных примитивных типов С# и  проинициализируйте их. 
        //Осуществите ввод и вывод их значений используя консоль.
        static void Case3()
        {
            Console.WriteLine("Case 1.3");

            Console.Write("int i = ");
            int i = Convert.ToInt32(Console.ReadLine());

            Console.Write("double d = ");
            double d = Convert.ToDouble(Console.ReadLine());

            Console.Write("decimal dc = ");
            decimal dc = Convert.ToDecimal(Console.ReadLine());

            Console.Write("char c = ");
            char c = Convert.ToChar(Console.ReadLine());

            Console.Write("string s = ");
            string s = Console.ReadLine();

            Console.Write("bool b = ");
            bool b = Convert.ToBoolean(Console.ReadLine());

            Console.WriteLine("i = " + i + ", d = " + d + ", dc = " + dc + ", c = " + c + ", s = " + s + ", b = " + b);
        }

        //Задание 1.4: 
        //Выполните упаковку и распаковку значимых типов.
        static void Case4()
        {
            Console.WriteLine("Case 1.4");

            object obj;

            int i1 = 7;
            double d1 = 2.5;
            decimal dc1 = 3.5m;
            char c1 = 'a';
            bool b1 = false;

            obj = i1;
            int i2 = (int)obj;

            obj = d1;
            double d2 = (double)obj;

            obj = dc1;
            decimal dc2 = (decimal)obj;

            obj = c1;
            char c2 = (char)obj;

            obj = b1;
            bool b2 = (bool)obj;

            Console.WriteLine("Checking:");
            Console.WriteLine(i1 + " " + d1 + " " + dc1 + " " + c1 + " " + b1);
            Console.WriteLine(i2 + " " + d2 + " " + dc2 + " " + c2 + " " + b2);
        }
    }
}

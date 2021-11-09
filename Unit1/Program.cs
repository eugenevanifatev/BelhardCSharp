using System;

namespace Unit1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Case3();
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
    }
}

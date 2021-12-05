using System;
using System.Collections.Generic;
using System.Text;

namespace Unit7.Exercise1
{
    //Найти для заданной строки количество пробелов.
    internal class Ex1Case3
    {
        public void FindNumberOfSymbols(char symbol)
        {
            Console.WriteLine("Case 1.3");

            Console.Write("Eter some words: ");
            string str = Console.ReadLine();

            char[] chars = str.ToCharArray();

            int count = 0;
            foreach(char c in chars)
            {
                if (c == symbol)
                    count++;
            }

            Console.WriteLine($"Number of \'{symbol}\': {count}");

            Console.ReadKey();
            Console.Clear();
        }
    }
}

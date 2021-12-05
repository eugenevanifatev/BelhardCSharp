using System;
using System.Collections.Generic;
using System.Text;

namespace Unit7.Exercise1
{
    //Задан массив целых чисел, объедините их в одно число. (Напр. 1,2,3 -> 123)
    internal class Ex1Case6
    {
        public void ConcatNumbers()
        {
            List<int> numbers = new List<int>();

            Console.WriteLine("Enter a few integers. Invalid entry is end of input.");
            for (; ; )
            {
                if (Int32.TryParse(Console.ReadLine(), out int number))
                    numbers.Add(number);
                else
                    break;
            }

            string result = string.Concat(numbers.ToArray());

            Console.WriteLine($"Result: {result}");

            Console.ReadKey();
            Console.Clear();
        }
    }
}

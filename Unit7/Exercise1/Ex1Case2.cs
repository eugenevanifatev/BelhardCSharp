using System;
using System.Collections.Generic;
using System.Text;

namespace Unit7.Exercise1
{
    //Найти для введенной строки индекс первой буквы О.
    internal class Ex1Case2
    {
        public void FindLetter(char letter)
        {
            Console.WriteLine("Case 1.2");

            Console.Write("Eter some words: ");
            string str = Console.ReadLine();

            int indexOfFirstO = str.IndexOf(letter);

            Console.WriteLine($"Index of first letter \'{letter}\': {indexOfFirstO}");

            Console.ReadKey();
            Console.Clear();
        }
    }
}

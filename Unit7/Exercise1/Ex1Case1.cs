using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Unit7.Exercise1
{
    //Вывести текст, составленный из последних букв всех слов фразы, введенной с клавиатуры.
    internal class Ex1Case1
    {
        public void SelectLastLetter()
        {
            Console.WriteLine("Case 1.1");

            Console.Write("Eter some words: ");
            string str = Console.ReadLine();

            var result = string.Concat(str.Split(new Char[] { ' ', ',', '.', '!', '?', ':', ';' }, StringSplitOptions.RemoveEmptyEntries).Select(word => word.Last()));

            Console.WriteLine($"Result: {result}");

            Console.ReadKey();
            Console.Clear();
        }
    }
}

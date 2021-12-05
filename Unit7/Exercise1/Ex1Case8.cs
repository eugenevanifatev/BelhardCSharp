using System;
using System.Collections.Generic;
using System.Text;

namespace Unit7.Exercise1
{
    //С клавиатуры вводят строку и символ. Проверьте, содержит ли введенная строка этот символ. Если содержит, удалить их.
    internal class Ex1Case8
    {
        public void Coincide()
        {
            //StringBuilder sb = new StringBuilder(Console.ReadLine());
            string s = Console.ReadLine();
            char c= GetChar();

            string result = s.Replace(Convert.ToString(c), string.Empty);

            Console.WriteLine(result);

            Console.ReadKey();
            Console.Clear();
        }

        char GetChar()
        {
            if (Char.TryParse(Console.ReadLine(), out char c))
                return c;
            else
            {
                Console.WriteLine("Incorrect character.");
                return GetChar(); 
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Unit7.Exercise1
{
    //Введите с консоли строку. Измените ее так чтобы последний символ продублировался.
    internal class Ex1Case7
    {
        public void DublicateLastSymbol()
        {
            string s = Console.ReadLine();

            string result = string.Concat(s, s.ToCharArray().Last());
            Console.WriteLine(result);
        }
    }
}

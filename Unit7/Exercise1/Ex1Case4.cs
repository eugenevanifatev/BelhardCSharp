using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Unit7.Exercise1
{
    //Создайте массив строк. Проинициализируйте. Отсортируйте его
    internal class Ex1Case4
    {
        public void Sort()
        {
            List<string> list = new List<string>();

            Console.Write("Enter number of strings: ");
            int count = GetNumber();

            for (int i = 0; i < count; i++)
            {
                list.Add(Console.ReadLine());
            }

            var sortList = list.OrderBy(m => m.Length);

            Console.WriteLine("\nSort massive of string:");
            foreach(string s in sortList)
            {
                Console.WriteLine(s);
            }

            Console.ReadKey();
            Console.Clear();
        }

        int GetNumber()
        {
            if(Int32.TryParse(Console.ReadLine(),out int count))
                return count;
            else
            {
                Console.WriteLine("Incorrect input.");
                return GetNumber();
            }
        }
    }
}

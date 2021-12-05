using System;
using System.Collections.Generic;
using System.Text;

namespace Unit7.Exercise1
{
    //Задана строка “123. 345. 678.” Разбейте строку на три по предложениям.
    internal class Ex1Case5
    {
        public void PartitionString()
        {
            string origin = "123. 345. 678.";
            var result = origin.Split(' ', StringSplitOptions.RemoveEmptyEntries);

            Console.WriteLine("Partition result:");
            foreach (var item in result)
                Console.WriteLine(item);

            Console.ReadKey();
            Console.Clear();
        }
    }
}

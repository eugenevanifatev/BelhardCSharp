using System;
using System.Collections.Generic;
using System.Text;

namespace Unit4
{
//    Задание 4.4: 
//1. Придумать свой собственный класс, чтобы он имел 3 поля разных типов и 2 метода
//2. Создать два экземпляра класса, инициализировать их поля и вызвать методы

    internal class Case4
    {
        public int number;
        public bool action;

        public void GetInfo()
        {
            Console.WriteLine("Metod \"DoMultiplication\" return number * 2 if action is true.");
        }

        public int DoMultiplication(int number, bool action)
        {
            if (action)
            {
                return number * 2;
            }
            else
            {
                return number;
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace Unit4
{
//    Задание 4.4: 
//1. Придумать свой собственный класс, чтобы он имел 3 поля разных типов и 2 метода
//2. Создать два экземпляра класса, инициализировать их поля и вызвать методы

//    Задание 4.5: 
//Добавить к классу из з.4.4 три конструктора - без параметров, с одним параметром, со всеми параметрами для полей


    internal class Case4Case5
    {
        public int number;
        public bool action;

        public Case4Case5() { action = true; number = 5; }
        public Case4Case5(int number) { action = true; this.number = number; }
        public Case4Case5(bool action, int number) { this.action = action; this.number = number; }

        public void GetInfo()
        {
            Console.WriteLine("Metod \"DoMultiplication\" return number * 2 if action is true.");
        }

        public int DoMultiplication()
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

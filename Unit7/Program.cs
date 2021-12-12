using System;
using Unit7.Exercise1;
using Unit7.Exercise2;

namespace Unit7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Case 7.1.1:");
            Ex1Case1 ex1Case1 = new Ex1Case1();
            ex1Case1.SelectLastLetter();

            Console.WriteLine("Case 7.1.2:");
            Ex1Case2 ex1Case2 = new Ex1Case2();
            ex1Case2.FindLetter('o');

            Console.WriteLine("Case 7.1.3:");
            Ex1Case3 ex1Case3 = new Ex1Case3();
            ex1Case3.FindNumberOfSymbols(' ');

            Console.WriteLine("Case 7.1.4:");
            Ex1Case4 ex1Case4 = new Ex1Case4();
            ex1Case4.Sort();

            Console.WriteLine("Case 7.1.5:");
            Ex1Case5 ex1Case5 = new Ex1Case5();
            ex1Case5.PartitionString();

            Console.WriteLine("Case 7.1.6:");
            Ex1Case6 ex1Case6 = new Ex1Case6();
            ex1Case6.ConcatNumbers();

            Console.WriteLine("Case 7.1.7:");
            Ex1Case7 ex1Case7 = new Ex1Case7();
            ex1Case7.DublicateLastSymbol();

            Console.WriteLine("Case 7.1.8:");
            Ex1Case8 ex1Case8 = new Ex1Case8();
            ex1Case8.Coincide();

            Ex2 ex2 = new Ex2();
            Console.WriteLine("Case 7.2.1:");
            ex2.SearchByName("Sergey");
            Console.WriteLine("Case 7.2.2:");
            ex2.SearchOldestStudents();
            Console.WriteLine("Case 7.2.3:");
            ex2.SearchStudentWithMore2Subjects();
            Console.WriteLine("Case 7.2.4:");
            ex2.SearchFemaleWithPrigramming();
            Console.WriteLine("Case 7.2.5:");
            ex2.SearchStudentWithUniqueSubject();
            Console.WriteLine("Case 7.2.6:");
            ex2.SearchStudetnsOfGroup(4);
            Console.WriteLine("Case 7.2.7:");
            ex2.SearchStudentWithNonUniqueSubject();
        }
    }
}

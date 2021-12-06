using System;
using Unit7.Exercise1;
using Unit7.Exercise2;

namespace Unit7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Ex1Case1 ex1Case1 = new Ex1Case1();
            ex1Case1.SelectLastLetter();

            Ex1Case2 ex1Case2 = new Ex1Case2();
            ex1Case2.FindLetter('o');

            Ex1Case3 ex1Case3 = new Ex1Case3();
            ex1Case3.FindNumberOfSymbols(' ');

            Ex1Case4 ex1Case4 = new Ex1Case4();
            ex1Case4.Sort();

            Ex1Case5 ex1Case5 = new Ex1Case5();
            ex1Case5.PartitionString();

            Ex1Case6 ex1Case6 = new Ex1Case6();
            ex1Case6.ConcatNumbers();

            Ex1Case7 ex1Case7 = new Ex1Case7();
            ex1Case7.DublicateLastSymbol();

            Ex1Case8 ex1Case8 = new Ex1Case8();
            ex1Case8.Coincide();

            Ex2 ex2 = new Ex2();
            ex2.SearchByName("Sergey");
            ex2.SearchOldestStudents();
            ex2.SearchStudentWithMore2Subjects();
            ex2.SearchFemaleWithPrigramming();
            //ex2.SearchStudentWithUniqueSubject();
            ex2.SearchStudetnsOfGroup(4);
        }
    }
}

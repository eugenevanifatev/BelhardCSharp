using System;
using System.Collections.Generic;
using System.Text;

namespace Unit7.Exercise2
{
    internal class ListOfStudents
    {
        public List<Student> students = new List<Student>
        {
            new Student{ Name = "Tom", Age = 21, GroupNumber = 1, Gender = "male", listOfFavoriteSubjects = {Subjects.Biology, Subjects.Programming} },
            new Student{ Name = "Sam", Age = 18, GroupNumber = 2, Gender = "male", listOfFavoriteSubjects = {Subjects.Economics, Subjects.Chemistry, Subjects.Math} },
            new Student{ Name = "Poly", Age = 19, GroupNumber = 1, Gender = "female", listOfFavoriteSubjects = {Subjects.Programming} },
            new Student{ Name = "Sergey", Age = 21, GroupNumber = 3, Gender = "male", listOfFavoriteSubjects = {Subjects.Biology, Subjects.Chemistry} },
            new Student{ Name = "Anna", Age = 22, GroupNumber = 2, Gender = "female", listOfFavoriteSubjects = {Subjects.Math, Subjects.Programming} },
            new Student{ Name = "John", Age = 20, GroupNumber = 4, Gender = "male", listOfFavoriteSubjects = {Subjects.Biology} },
            new Student{ Name = "Sara", Age = 17, GroupNumber = 3, Gender = "female", listOfFavoriteSubjects = {Subjects.Biology, Subjects.Programming, Subjects.Physics, Subjects.Economics} },
            new Student{ Name = "Petr", Age = 23, GroupNumber = 1, Gender = "male", listOfFavoriteSubjects = {Subjects.Programming, Subjects.Physics} },
            new Student{ Name = "Rick", Age = 23, GroupNumber = 3, Gender = "male", listOfFavoriteSubjects = {Subjects.Chemistry, Subjects.Biology} },
            new Student{ Name = "Ava", Age = 21, GroupNumber = 4, Gender = "female", listOfFavoriteSubjects = {Subjects.Economics, Subjects.Math} },
            new Student{ Name = "Emma", Age = 20, GroupNumber = 2, Gender = "female", listOfFavoriteSubjects = {Subjects.Biology, Subjects.Physics, Subjects.Chemistry, Subjects.Math} },
            new Student{ Name = "Stive", Age = 20, GroupNumber = 2, Gender = "male", listOfFavoriteSubjects = {Subjects.History} }
        };

        public void GetStudentInfo(IEnumerable<Student>result)
        {
            foreach (var student in result)
            {
                Console.Write($"Name: {student.Name}, Age: {student.Age}, Group number: {student.GroupNumber}, Gender: {student.Gender}, Favorite subjects: ");
                foreach (var subject in student.listOfFavoriteSubjects)
                    Console.Write($"{subject} ");
                Console.WriteLine();
            }
        }
    }
}

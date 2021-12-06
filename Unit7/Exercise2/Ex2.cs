using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Unit7.Exercise2
{
    //Найти(и проверить, если такие имеются) :
    internal class Ex2
    {
        ListOfStudents listOfStudents = new ListOfStudents();

        //1.Студентов с именем Сергей
        public void SearchByName(string name)
        {
            Console.WriteLine($"Students with name {name}:");

            var result = listOfStudents.students.Where(s => s.Name == name);

            listOfStudents.GetStudentInfo(result);
        }

        //2.Самых старших студентов
        public void SearchOldestStudents()
        {
            Console.WriteLine("Oldest Students:");

            var result = listOfStudents.students.Where(s => s.Age == listOfStudents.students.Max(m => m.Age));

            listOfStudents.GetStudentInfo(result);
        }

        //3.Имеющих более двух любимых предметов
        public void SearchStudentWithMore2Subjects()
        {
            Console.WriteLine("Students with more than two favorite subjects:");

            var result = listOfStudents.students.Where(s => s.listOfFavoriteSubjects.Count > 2);

            listOfStudents.GetStudentInfo(result);
        }

        //4.Всех девушек, любящих программирование
        public void SearchFemaleWithPrigramming()
        {
            Console.WriteLine("Girls who prefer programming:");

            var result = listOfStudents.students.Where(s => s.Gender == "female" && s.listOfFavoriteSubjects.Contains(Subjects.Programming));

            listOfStudents.GetStudentInfo(result);
        }

        //5.Студентов, которые единственные любят какой-то предмет (напр. только Сережа любит Историю)
        //не решил
        public void SearchStudentWithUniqueSubject()
        {
            Console.WriteLine("Students who are the only ones who love the subject:");

            var result = listOfStudents.students.GroupBy(s => s.listOfFavoriteSubjects);

            foreach (var item in result)
                Console.WriteLine(item.Key);

        }

        //6.Выборку из имен и возрастов студентов, которые учатся в группе №...
        public void SearchStudetnsOfGroup(int groupNumber)
        {
            Console.WriteLine($"Students from {groupNumber} group:");

            var result = listOfStudents.students.Where(s => s.GroupNumber == groupNumber).Select(m => new { m.Name, m.Age });

            foreach (var item in result)
                Console.WriteLine($"{item}");
        }

        //7.Студентов , у которых есть пересечение по любимым предметам
    }
}

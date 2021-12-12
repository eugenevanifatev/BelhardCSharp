using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

            Console.ReadKey();
            Console.Clear();
        }

        //2.Самых старших студентов
        public void SearchOldestStudents()
        {
            Console.WriteLine("Oldest Students:");

            var result = listOfStudents.students.Where(s => s.Age == listOfStudents.students.Max(m => m.Age));

            listOfStudents.GetStudentInfo(result);

            Console.ReadKey();
            Console.Clear();
        }

        //3.Имеющих более двух любимых предметов
        public void SearchStudentWithMore2Subjects()
        {
            Console.WriteLine("Students with more than two favorite subjects:");

            var result = listOfStudents.students.Where(s => s.listOfFavoriteSubjects.Count > 2);

            listOfStudents.GetStudentInfo(result);

            Console.ReadKey();
            Console.Clear();
        }

        //4.Всех девушек, любящих программирование
        public void SearchFemaleWithPrigramming()
        {
            Console.WriteLine("Girls who prefer programming:");

            var result = listOfStudents.students.Where(s => s.Gender == "female" && s.listOfFavoriteSubjects.Contains(Subjects.Programming));

            listOfStudents.GetStudentInfo(result);

            Console.ReadKey();
            Console.Clear();
        }

        //5.Студентов, которые единственные любят какой-то предмет (напр. только Сережа любит Историю)
        //не решил
        public void SearchStudentWithUniqueSubject()
        {
            var allFavSubjs = new List<Subjects>();

            foreach (var stud in listOfStudents.students)
            {
                allFavSubjs.AddRange(stud.listOfFavoriteSubjects);
            }
            var groups = allFavSubjs.GroupBy(m => m).Where(e => e.Count() == 1);

            foreach (var group in groups)
            {
                Console.WriteLine("Students who are the only ones who love the subject: " + group.Key);
                Console.WriteLine("This student: " + listOfStudents.students.Single(m => m.listOfFavoriteSubjects.Contains(group.Key)).Name + "\n-----------------------");
            }

            Console.ReadKey();
            Console.Clear();
        }

        //6.Выборку из имен и возрастов студентов, которые учатся в группе №...
        public void SearchStudetnsOfGroup(int groupNumber)
        {
            Console.WriteLine($"Students from {groupNumber} group:");

            var result = listOfStudents.students.Where(s => s.GroupNumber == groupNumber).Select(m => new { m.Name, m.Age });

            foreach (var item in result)
                Console.WriteLine($"{item}");

            Console.ReadKey();
            Console.Clear();
        }

        //7.Студентов , у которых есть пересечение по любимым предметам

        public void SearchStudentWithNonUniqueSubject()
        {
            var allFavSubjs = new List<Subjects>();

            foreach (var stud in listOfStudents.students)
            {
                allFavSubjs.AddRange(stud.listOfFavoriteSubjects);
            }
            var groups = allFavSubjs.GroupBy(m => m).Where(e => e.Count() > 1);

            foreach (var group in groups)
            {
                Console.WriteLine("Students who love the subject: " + group.Key);
                var studs = listOfStudents.students.
                            Where(m => m.listOfFavoriteSubjects.
                            Contains(group.Key));
                Parallel.ForEach(studs, m =>
                {
                    Console.WriteLine(m.Name + " ");
                });
                Console.WriteLine("---------------------");
            }

            Console.ReadKey();
            Console.Clear();
        }
    }
}

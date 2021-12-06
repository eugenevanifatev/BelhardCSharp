using System;
using System.Collections.Generic;
using System.Text;

namespace Unit7.Exercise2
{
    enum Subjects
    {
        Biology,
        Chemistry,
        Economics,
        Math,
        Physics,
        Programming
    }

    internal class Student
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public int GroupNumber { get; set; }
        public string Gender { get; set; }
        public List<Subjects> listOfFavoriteSubjects = new List<Subjects>();
    }



}

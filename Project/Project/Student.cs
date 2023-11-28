using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project
{
    class Student : Person
    {
        protected string University;
        protected int StudentID;

        public Student(string firstName, string lastName, DateTime birthDate, string university, int studentID) : base(firstName, lastName, birthDate)
        {
            University = university;
            StudentID = studentID;
        }

        public override object DeepCopy()
        {
            // Виконати глибоку копію об'єкту
            return new Student(FirstName, LastName, BirthDate, University, StudentID);
        }


    }
}

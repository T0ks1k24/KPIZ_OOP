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
        protected ArrayList Tests;
        protected ArrayList Exams;

        public Student(string firstName, string lastName, DateTime birthDate, string university, int studentID, string educationForm, int groupNumber)
            : base(firstName, lastName, birthDate)
        {
            University = university;
            StudentID = studentID;
            this.educationForm = educationForm;
            this.groupNumber = groupNumber;
            tests = new ArrayList();
            exams = new ArrayList();

        public override object DeepCopy()
        {
            // Виконати глибоку копію об'єкту
            return new Student(FirstName, LastName, BirthDate, University, StudentID);
        }

        public void AddTest(Test test)
        {
            tests.Add(test);
        }

        public void AddExam(Exam exam)
        {
            exams.Add(exam);
        }

        public override object DeepCopy()
        {
            Student copiedStudent = new Student(FirstName, LastName, BirthDate, University, StudentID, educationForm, groupNumber);

            // Copy tests
            foreach (Test test in tests)
            {
                copiedStudent.AddTest((Test)test.DeepCopy());
            }

            // Copy exams
            foreach (Exam exam in exams)
            {
                copiedStudent.AddExam((Exam)exam.DeepCopy());
            }

            return copiedStudent;
        }


    }
}

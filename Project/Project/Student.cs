using System;
using System.Collections;
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
        protected string EducationForm;
        protected int GroupNumber;
        protected ArrayList Tests;
        protected ArrayList Exams;

        public Student(string firstName, string lastName, DateTime birthDate, string university, int studentID, string educationForm, int groupNumber)
            : base(firstName, lastName, birthDate)
        {
            University = university;
            StudentID = studentID;
            EducationForm = educationForm;
            GroupNumber = groupNumber;
            Tests = new ArrayList();
            Exams = new ArrayList();
        }


        public void AddTest(Test test)
        {
            Tests.Add(test);
        }

        public void AddExam(Exam exam)
        {
            Exams.Add(exam);
        }

        public override object DeepCopy()
        {
            Student copiedStudent = new Student(FirstName, LastName, BirthDate, University, StudentID, EducationForm, GroupNumber);

            // Copy tests
            foreach (Test test in Tests)
            {
                copiedStudent.AddTest((Test)test.DeepCopy());
            }

            // Copy exams
            foreach (Exam exam in Exams)
            {
                copiedStudent.AddExam((Exam)exam.DeepCopy());
            }

            return copiedStudent;
        }


    }
}

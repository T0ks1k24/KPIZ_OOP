using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project
{
    class Student : Person
    {
        private int StudentID;
        private string Department;
        public Student(string name, string address, DateTime date, int studentID, string department) : base(name, address, date)
        {
            StudentID = studentID;
            Department = department;
        }

        public object DeepCopy()
        {
            return new Student(Name, Address, Date, StudentID, Department);
        }
    }
}

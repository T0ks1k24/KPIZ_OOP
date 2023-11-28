using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project
{
    class Exam : IDateAndCopy
    {
        public string Subject;
        public int Grade;
        public DateTime ExamDate;

        public Exam(string subject, int grade, DateTime examDate)
        {
            Subject = subject;
            Grade = grade;
            ExamDate = examDate;
        }

        public DateTime Date
        {
            get { return ExamDate; }
            set { ExamDate = value; }
        }

        public object DeepCopy()
        {
            // Виконати глибоку копію об'єкту
            return new Exam(Subject, Grade, ExamDate);
        }
    }
}

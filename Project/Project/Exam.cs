using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project
{
    class Exam : IDateAndCopy
    {
        protected int Mark;
        protected string Subject;
        public DateTime Date {  get; set; }
        public Exam(int mark, string subject, DateTime date) 
        {
            Mark = mark;
            Subject = subject;
            Date = date;
        }
        public object DeepCopy()
        {
            return new Exam(Mark, Subject, Date);
        }

    }
}

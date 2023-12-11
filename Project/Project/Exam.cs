using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project
{
    class Exam : IDateAndCopy
    {
        public DateTime ExamDate;
        public string Subject { get; set; }
        public int Score { get; set; }



        public DateTime Date
        {
            get { return ExamDate; }
            set { ExamDate = value; }
        }

        public object DeepCopy()
        {
            return new Exam { Subject = this.Subject, Score = this.Score };
        }




    }
}

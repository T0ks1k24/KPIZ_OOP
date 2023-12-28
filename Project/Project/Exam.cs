using Project;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project
{
    class Exam : Test
    {
        public int Mark { get; set; }
        public Exam(string nameSubject, bool passed, int Mark)
        {
            this.Mark = Mark;
            this.nameSubject = nameSubject;
            this.passed = passed;
        }
        public Exam() { }


    }
}

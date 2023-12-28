using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project
{
    class Test
    {
        public string nameSubject { get; set; }
        public bool passed { get; set; }

        public Test(string nameSubject, bool passed)
        {
            this.nameSubject = nameSubject;
            this.passed = passed;
        }

        public Test()
        {
            nameSubject = "DefaultSubject";
            passed = false;
        }

        public virtual string ToString()
        {
            return $"Subject: {nameSubject}, Passed: {passed}";
        }



    }
}

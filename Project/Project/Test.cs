using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project
{
    class Test
    {
        // Властивості класу
        public string SubjectName { get; set; }
        public bool Passed { get; set; }

        // Конструктор з параметрами
        public Test(string subjectName, bool passed)
        {
            SubjectName = subjectName;
            Passed = passed;
        }

        // Конструктор без параметрів (зі значеннями за умовчанням)
        public Test()
        {
            SubjectName = "Невідомий предмет";
            Passed = false;
        }

        // Перевантажений метод ToString()
        public override string ToString()
        {
            return $"Предмет: {SubjectName}, Зданий залік: {Passed}";
        }
    }

}

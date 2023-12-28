using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Project
{
    enum Education
    {
        Bachelor, Master, PhD
    }

    class Student : Person
    {
        private Education education;
        private int groupNum;
        private ArrayList testsList;
        private ArrayList examsList;

        public DateTime Date { get; set; }

        public Student(Person person, Education education, int groupNum, ArrayList testsList, ArrayList examsList) : base(person.FirstName, person.LastName, person.BirthDate)
        {
            this.education = education;
            this.groupNum = groupNum;
            this.testsList = testsList;
            this.examsList = examsList;
        }

        public Student() : this(new Person("Default", "Student", DateTime.Now), Education.Bachelor, 101, new ArrayList(), new ArrayList()) { }


        public Person PersonData
        {
            get { return new Person(FirstName, LastName, BirthDate); }
            set { FirstName = value.FirstName; LastName = value.LastName; BirthDate = value.BirthDate; }
        }

        public double AvgMark
        {
            get
            {
                double sum = 0.0;
                if (examsList.Count == 0)
                    return 0.0;

                foreach (Exam exam in examsList)
                    sum += exam.Mark;

                return sum / examsList.Count;
            }
        }

        public ArrayList ExamsList { get; set; }

        public void AddExam(params Exam[] newExams) { examsList.AddRange(newExams); }

        public override string ToString()
        {
            return $"Student: {PersonData.FirstName} {PersonData.LastName}, Birthdate: {PersonData.BirthDate.ToShortDateString()}, Education: {education}, Group: {groupNum}, Exams Count: {examsList.Count}, Tests Count: {testsList.Count}";
        }

        public virtual string ToShortString()
        {
            return $"Student: {PersonData.FirstName} {PersonData.LastName}, Birthdate: {PersonData.BirthDate.ToShortDateString()}, Education: {education}, Group: {groupNum}, Exams Count: {examsList.Count}, Tests Count: {testsList.Count}";
        }

        public override object DeepCopy()
        {
            Student copyStudent = new Student(PersonData, education, groupNum, testsList, examsList);
            copyStudent.testsList = new ArrayList(testsList);
            copyStudent.examsList = new ArrayList(examsList);

            return copyStudent;
        }

        public int GroupNumber
        {
            get { return groupNum; }
            set
            {
                if (value < 100 || value > 599)
                    throw new ArgumentOutOfRangeException("Номер групи повинен бути від 100 до 599.");
                groupNum = value;
            }
        }

        public IEnumerable<string> GetEnumerator()
        {
            foreach (var test in testsList)
                yield return (test as Test)?.nameSubject;

            foreach (var exam in examsList)
                yield return (exam as Exam)?.nameSubject;
        }


        public IEnumerable<string> GetExamsWithGradeGreaterThan(int grade)
        {
            foreach (Exam exam in examsList)
                if (exam.Mark > grade)
                    yield return exam.nameSubject;
        }

        public IEnumerable<string> GetPasssedTestsAndExamsEnumerator()
        {
            foreach (Exam exam in examsList)
                if (exam.Mark > 2 && exam.passed)
                    yield return exam.nameSubject;

            foreach (Test test in testsList)
                if (test.passed)
                    yield return test.nameSubject;
        }

        public IEnumerable<string> GetPasssedTestsWithExamEnumerator()
        {
            foreach (Exam exam in examsList)
                if (exam.Mark > 2 && exam.passed)
                    foreach (Test test in testsList)
                        if (test.nameSubject == exam.nameSubject && test.passed)
                            yield return test.nameSubject;
        }


        public IEnumerable<string> GetEnumeratorList()
        {
            foreach (Test test in testsList)
                if (test.passed)
                    yield return test.nameSubject;

            foreach (Exam exam in examsList)
                if (exam.passed)
                    yield return exam.nameSubject;
        }



    }
}
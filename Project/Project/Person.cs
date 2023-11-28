using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project
{
    class Person : IDateAndCopy
    {
        protected string FirstName;
        protected string LastName;
        protected DateTime BirthDate;

        public Person(string firstName, string lastName, DateTime birthDate)
        {
            FirstName = firstName;
            LastName = lastName;
            BirthDate = birthDate;
        }
        public DateTime Date
        {
            get { return BirthDate; }
            set { BirthDate = value; }
        }

        public virtual object DeepCopy()
        {
            // Виконати глибоку копію об'єкту
            return new Person(FirstName, LastName, BirthDate);
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project
{
    class Person : IDateAndCopy
    {
        protected string firstName;
        protected string lastName;
        protected DateTime birthDate;

        public DateTime Date { get; set; }

        public Person(string firstName, string lastName, DateTime birthDate)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.birthDate = birthDate;
        }

        public string FirstName
        {
            get { return firstName; }
            set { firstName = value; }
        }

        public string LastName
        {
            get { return lastName; }
            set { lastName = value; }
        }

        public DateTime BirthDate
        {
            get { return birthDate; }
            set { birthDate = value; }
        }

        public override bool Equals(object obj)
        {
            if (obj is null || GetType() != obj.GetType())
                return false;

            Person otherPerson = (Person)obj;

            return FirstName == otherPerson.FirstName &&
                   LastName == otherPerson.LastName &&
                   BirthDate == otherPerson.BirthDate;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(firstName, lastName, birthDate);
        }

        public virtual object DeepCopy()
        {
            return new Person(firstName, lastName, birthDate);
        }

        public DateTime Data
        {
            get { return birthDate; }
            set { birthDate = value; }
        }

        public static bool operator ==(Person person1, Person person2)
        {
            if (ReferenceEquals(person1, person2))
                return true;
            if (person1 is null || person2 is null)
                return false;

            return person1.Equals(person2);
        }

        public static bool operator !=(Person person1, Person person2)
        {
            return !(person1 == person2);
        }
    }
}

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

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime BirthDate { get; set; }

        public override bool Equals(object obj)
        {
            if (obj is null || ReferenceEquals(this, obj))
                return false;

            if (obj is not Person otherPerson)
                return false;

            return GetHashCode() == otherPerson.GetHashCode();
        }

        public int GetHashCode()
        {
            return HashCode.Combine(firstName, lastName, birthDate);
        }

        public virtual object DeepCopy()
        {
            return new Person(firstName, lastName, birthDate);
        }

        public DateTime Data { get => birthDate; set => birthDate = value; }

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

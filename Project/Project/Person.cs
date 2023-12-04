using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project
{
    class Person : IDateAndCopy
    {
        // Основні властивості класу Person
        protected string FirstName { get; set; }    
        protected string LastName { get; set; }
        protected DateTime BirthDate { get; set; }

        // Конструктор класу
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

        // Реалізація інтерфейсу IDateAndCopy
        public object DeepCopy()
        {
            Person copiedPerson = new Person(FirstName, LastName, BirthDate);
            return copiedPerson;
        }

        // Перевизначення методу Equals
        public override bool Equals(object obj)
        {
            //Викликає перевизначений метод Equals, який ми написали у класі Person.
            //Цей метод порівнює властивості об'єктів для визначення їхньої рівності.
            if (obj == null || GetType() != obj.GetType()) return false;

            Person otherPerson = (Person)obj;

            return FirstName == otherPerson.FirstName &&
                   LastName == otherPerson.LastName &&
                   BirthDate == otherPerson.BirthDate;
        }

        // Перевизначення методу GetHashCode
        public override int GetHashCode()
        {
            return HashCode.Combine(FirstName, LastName, BirthDate);
        }

        // Перевизначення операторів == і !=
        // Викликаємо оператор == і негуємо його результат(!(person1 == person2))
        public static bool operator ==(Person person1, Person person2)
        {
            //Перевіряє, чи обидва об'єкти вказують на одне і те саме місце в пам'яті
            //(вони є однаковими за посиланням).Якщо це так, то вони точно рівні, і повертається true.
            if (ReferenceEquals(person1, person2))
            {
                return true;
            }
            //Перевіряє, чи хоча б один із об'єктів є null.
            //Якщо це так, то об'єкти не можуть бути рівними, і повертається false.
            if (person1 is null || person2 is null)
            {
                return false;
            }

            return person1.Equals(person2);
        }
        //Це означає, що != повертає true, коли об'єкти не рівні, і false, коли вони рівні.
        public static bool operator !=(Person person1, Person person2)
        {
            return !(person1 == person2);
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project
{
    class Person : IDateAndCopy
    {
        protected string Name { get; set; }
        protected string Address { get; set; }
        public DateTime Date { get; set; }
        public Person(string name, string address, DateTime date)
        {
            Name = name;
            Address = address;
            Date = date;
        }
        public object DeepCopy()
        {
            return new Person(Name, Address, Date);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project
{
    interface IDateAndCopy
    {
        public object DeepCopy();
        public DateTime Date { get; set; }
    }

}


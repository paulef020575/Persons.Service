using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persons
{
    public class Person
    {
        public Guid Id { get; set; }

        public string Name { get; set; }

        public DateTime Birthday { get; set; }

        public decimal Age
        {
            get
            {
                DateTime today = DateTime.Today;
                int age = today.Year - Birthday.Year;
                if (today.Month < Birthday.Month
                    || (today.Month == Birthday.Month && today.Day < Birthday.Day))
                    age--;

                return age;
            }
        }
    }
}

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

        public int Age
        {
            get { return GetAge(Birthday); }
        }

        internal Person() { }

        public static int GetAge(DateTime birthday)
        {
            DateTime today = DateTime.Today;
            int age = today.Year - birthday.Year;
            if (today.Month < birthday.Month
                || (today.Month == birthday.Month && today.Day < birthday.Day))
                age--;

            return age;
        }

    }
}

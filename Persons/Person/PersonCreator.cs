using System;

namespace Persons
{
    public class PersonCreator : IPersonCreator
    {
        public Person Create(string name, DateTime birthday)
        {
            if (string.IsNullOrEmpty(name) || Person.GetAge(birthday) > 120)
                return null;

            return new Person
            {
                Id = Guid.NewGuid(),
                Name = name,
                Birthday = birthday
            };
        }
    }
}

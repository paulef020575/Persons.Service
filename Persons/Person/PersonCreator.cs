using System;

namespace Persons
{
    public class PersonCreator : IPersonCreator
    {
        public Person Create(Guid id, string name, DateTime birthday)
        {
            if (string.IsNullOrEmpty(name) || Person.GetAge(birthday) > 120)
                return null;

            return new Person
            {
                Id = id,
                Name = name,
                Birthday = birthday
            };
        }
    }
}

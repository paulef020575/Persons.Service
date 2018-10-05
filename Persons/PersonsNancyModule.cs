using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Nancy;

namespace Persons
{
    public class PersonsNancyModule : NancyModule
    {
        public PersonsNancyModule(IPersonRepository personRepository)
        {
            Get["/"] = param =>
            {
                personRepository.Insert(new Person
                {
                    Id = Guid.NewGuid(),
                    Name = "Efremov Pavel",
                    Birthday = new DateTime(1975, 2, 1)
                });

                return "Создан";
            };
            Get["/test"] = param =>
            {
                return personRepository.Find(Guid.Parse("bba5d28d-fb8d-4cf7-b44f-fd22650c066e")).Name;
            };
        }


    }
}

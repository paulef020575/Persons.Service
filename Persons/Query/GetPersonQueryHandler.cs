using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using Persons.Abstractions;

namespace Persons
{
    public class GetPersonQueryHandler : IQueryHandler<GetPersonQuery, PersonDto>
    {
        private IPersonRepository PersonRepository { get; }

        public GetPersonQueryHandler(IPersonRepository personRepository)
        {
            PersonRepository = personRepository;
        }
    
        public PersonDto Handle(GetPersonQuery query)
        {
            Person person = PersonRepository.Find(query.Id);

            if (person != null)
            {
                return new PersonDto
                {
                    Name = person.Name,
                    BirthDay = person.Birthday
                };
            }
            else
            {
                return null;
            }
        }
    }
}

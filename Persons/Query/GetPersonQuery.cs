using System;
using Persons.Abstractions;

namespace Persons
{
    public class GetPersonQuery : IQuery<PersonDto>
    {
        public Guid Id { get; set; }
    }
}

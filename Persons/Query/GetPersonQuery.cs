using System;
using Persons.Abstractions;

namespace Persons
{
    public class GetPersonQuery : IQuery<Person>
    {
        public Guid Id { get; set; }
    }
}

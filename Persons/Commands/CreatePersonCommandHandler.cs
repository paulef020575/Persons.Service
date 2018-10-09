using System;
using Persons.Abstractions;

namespace Persons
{
    public class CreatePersonCommandHandler : ICommandHandler<CreatePersonCommand>
    {
        private IPersonCreator PersonCreator { get; }
        private IPersonRepository PersonRepository { get; }

        public CreatePersonCommandHandler(
            IPersonCreator personCreator,
            IPersonRepository personRepository)
        {
            PersonCreator = personCreator;
            PersonRepository = personRepository;
        }

        public void Execute(CreatePersonCommand command)
        {
            Person person = PersonCreator.Create(command.Id, command.Name, command.BirthDay);
            if (person != null)
            {
                PersonRepository.Insert(person);
            }
            else
            {
                throw new ArgumentException();
            }
        }
    }
}

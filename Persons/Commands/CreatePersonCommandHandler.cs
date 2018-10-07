using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Persons.Abstractions;

namespace Persons.Commands
{
    public class CreatePersonCommandHandler : ICommandHandler<CreatePersonCommand>
    {
        private IPersonRepository PersonRepository { get; }

        public CreatePersonCommandHandler(IPersonRepository personRepository)
        {
            PersonRepository = personRepository;
        }

        public void Execute(CreatePersonCommand command)
        {
                    }
    }
}

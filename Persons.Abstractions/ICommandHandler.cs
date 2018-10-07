using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persons.Abstractions
{
    public interface ICommandHandler<in T>
    {
        void Execute(T command);
    }
}

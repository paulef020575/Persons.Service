using System;

namespace Persons
{
    public interface IPersonCreator
    {
        Person Create(Guid id, string name, DateTime birthday);
    }
}

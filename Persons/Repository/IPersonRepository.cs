using System;

namespace Persons
{
    public interface IPersonRepository
    {
        Person Find(Guid id);
        void Insert(Person item);
    }
}
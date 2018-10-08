using System;

namespace Persons
{
    public interface IPersonCreator
    {
        Person Create(string name, DateTime birthday);
    }
}

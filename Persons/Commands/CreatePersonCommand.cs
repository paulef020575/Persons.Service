using System;

namespace Persons
{
    public class CreatePersonCommand
    {
        #region Data

        public Guid Id { get; set; }

        public string Name { get; set; }

        public DateTime BirthDay { get; set; }

        #endregion
    }
}

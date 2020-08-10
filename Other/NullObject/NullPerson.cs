using System;

namespace NullObject
{
    class NullPerson : IPerson
    {
        public string Name => "John Doe";
        public DateTime DateOfBirth => DateTime.MinValue;
    }
}
using System;

namespace NullObject
{
    public class Person : IPerson
    {
        public string Name { get; }
        public DateTime DateOfBirth { get; }

        public Person(string name, DateTime dateOfBirth)
        {
            Name = name;
            DateOfBirth = dateOfBirth;
        }
    }
}
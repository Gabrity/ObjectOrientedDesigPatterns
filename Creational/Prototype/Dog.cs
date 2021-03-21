using System;

namespace Prototype
{
    internal class Dog : IAnimal
    {
        public string Name { get; }
        public IIdentifier Identifier { get; set;  }

        public Dog(string name, IIdentifier identifier)
        {
            Name = name;
            Identifier = identifier;
        }
        
        public IPrototype ShallowCopy()
        {
            return (IPrototype) MemberwiseClone();
        }

        public IPrototype DeepCopy()
        {
            var deepCopyDog = (IAnimal) MemberwiseClone();
            deepCopyDog.Identifier = new Identifier(Identifier.Id);
            return deepCopyDog;
        }

        public override string ToString()
        {
            return Name + ", " + Identifier.Id;
        }
    }
}

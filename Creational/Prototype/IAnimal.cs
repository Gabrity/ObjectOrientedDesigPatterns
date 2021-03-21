using System;

namespace Prototype
{
    public interface IAnimal : IPrototype
    {
        IIdentifier Identifier { get; set; }
    }
}
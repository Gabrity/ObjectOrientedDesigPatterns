using System;

namespace Prototype
{
    public interface IAnimal
    {
        IAnimal Clone();
        void MakeSound();
    }
}
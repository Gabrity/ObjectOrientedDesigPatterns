using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype
{
    internal class Cat : IAnimal
    {
        public string Name { get; }
        public Cat(string name)
        {
            Name = name;
        }
        
        public IAnimal Clone()
        {
            return this;
        }

        public void MakeSound()
        {
            Console.WriteLine($"Meow. I am {Name}");
        }
    }
}

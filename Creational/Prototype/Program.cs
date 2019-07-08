using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype
{
    class Program
    {
        static void Main(string[] args)
        {
            IAnimal animal = new Cat("Tom");
            //IAnimal animal = new Dog("Harry");

            IAnimal newAnimal = animal.Clone();
            newAnimal.MakeSound();
            Console.ReadLine();
        }
    }
}

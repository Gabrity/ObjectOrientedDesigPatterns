using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype
{
    /*
     * Prototype: Specify the kinds of objects to create using a prototypical instance, and create new objects by copying this prototype.
     */
    class Program
    {
        static void Main(string[] args)
        {
            IAnimal firstDog = new Dog("Buksi", new Identifier(42));
            IPrototype shallowCopyDog = firstDog.ShallowCopy();
            IPrototype deepCopyDog = firstDog.DeepCopy();
            
            PrintAnimals(firstDog, shallowCopyDog, deepCopyDog);

            firstDog.Identifier.Id = 4;

            PrintAnimals(firstDog, shallowCopyDog, deepCopyDog);

            Console.ReadLine();
        }

        private static void PrintAnimals(IAnimal firstDog, IPrototype shallowCopy, IPrototype deepCopy)
        {
            Console.WriteLine(firstDog.ToString());
            Console.WriteLine(shallowCopy.ToString());
            Console.WriteLine(deepCopy.ToString());
        }
    }
}

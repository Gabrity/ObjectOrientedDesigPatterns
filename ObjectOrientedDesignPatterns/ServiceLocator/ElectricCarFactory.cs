using System;

namespace ServiceLocator
{
    internal class ElectricCarFactory : ICarFactory
    {
        public void BuildCar()
        {
            Console.WriteLine("Building electric car");
        }
    }
}
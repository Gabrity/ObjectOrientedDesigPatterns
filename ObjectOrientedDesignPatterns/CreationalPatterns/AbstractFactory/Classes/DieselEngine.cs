using System;

namespace ObjectOrientedDesignPatterns.CreationalPatterns.AbstractFactory
{
    internal class DieselEngine : IEngine
    {
        public void Start()
        {
            Console.WriteLine("Staring diesel engine.");
        }
    }
}
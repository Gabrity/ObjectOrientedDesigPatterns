using System;
using ObjectOrientedDesignPatterns.CreationalPatterns.AbstractFactory.Interfaces;

namespace ObjectOrientedDesignPatterns.CreationalPatterns.AbstractFactory.Classes
{
    internal class DieselEngine : IEngine
    {
        public void Start()
        {
            Console.WriteLine("Staring diesel engine.");
        }
    }
}
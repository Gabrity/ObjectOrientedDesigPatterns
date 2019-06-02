using System;

namespace ObjectOrientedDesignPatterns.CreationalPatterns.AbstractFactory
{
    internal class ElectricEngine : IEngine
    {
        public void Start()
        {
            Console.WriteLine("Starting electric engine.");
        }
    }
}
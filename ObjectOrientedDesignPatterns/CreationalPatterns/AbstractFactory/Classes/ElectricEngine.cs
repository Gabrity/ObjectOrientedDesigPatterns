using System;
using ObjectOrientedDesignPatterns.CreationalPatterns.AbstractFactory.Interfaces;

namespace ObjectOrientedDesignPatterns.CreationalPatterns.AbstractFactory.Classes
{
    internal class ElectricEngine : IEngine
    {
        public void Start()
        {
            Console.WriteLine("Starting electric engine.");
        }
    }
}
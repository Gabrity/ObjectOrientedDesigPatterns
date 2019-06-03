using System;
using ObjectOrientedDesignPatterns.Interfaces;

namespace ObjectOrientedDesignPatterns.Classes
{
    internal class ElectricEngine : IEngine
    {
        public void Start()
        {
            Console.WriteLine("Starting electric engine.");
        }
    }
}
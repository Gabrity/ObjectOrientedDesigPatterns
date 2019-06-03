using System;
using ObjectOrientedDesignPatterns.Interfaces;

namespace ObjectOrientedDesignPatterns.Classes
{
    internal class DieselEngine : IEngine
    {
        public void Start()
        {
            Console.WriteLine("Starting diesel engine.");
        }
    }
}
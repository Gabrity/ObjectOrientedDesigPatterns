using System;
using ObjectOrientedDesignPatterns.CreationalPatterns.AbstractFactory.Interfaces;

namespace ObjectOrientedDesignPatterns.CreationalPatterns.AbstractFactory.Classes
{
    internal class ElectricCarBattery : IFuelContainer
    {
        public void GetFuel()
        {
            Console.WriteLine("Getting electricity.");
        }
    }
}
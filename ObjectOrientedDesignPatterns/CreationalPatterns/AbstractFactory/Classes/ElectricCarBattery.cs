using System;

namespace ObjectOrientedDesignPatterns.CreationalPatterns.AbstractFactory
{
    internal class ElectricCarBattery : IFuelContainer
    {
        public void GetFuel()
        {
            Console.WriteLine("Getting electricity.");
        }
    }
}
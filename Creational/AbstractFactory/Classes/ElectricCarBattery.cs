using System;
using ObjectOrientedDesignPatterns.Interfaces;

namespace ObjectOrientedDesignPatterns.Classes
{
    internal class ElectricCarBattery : IFuelContainer
    {
        public void GetFuel()
        {
            Console.WriteLine("Getting electricity.");
        }
    }
}
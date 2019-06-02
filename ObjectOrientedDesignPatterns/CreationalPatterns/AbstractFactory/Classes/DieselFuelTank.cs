using System;

namespace ObjectOrientedDesignPatterns.CreationalPatterns.AbstractFactory
{
    internal class DieselFuelTank : IFuelContainer
    {
        public void GetFuel()
        {
            Console.WriteLine("Getting diesel.");
        }
    }
}
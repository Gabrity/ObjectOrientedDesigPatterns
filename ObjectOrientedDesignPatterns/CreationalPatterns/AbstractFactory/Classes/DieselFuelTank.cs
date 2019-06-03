using System;
using ObjectOrientedDesignPatterns.CreationalPatterns.AbstractFactory.Interfaces;

namespace ObjectOrientedDesignPatterns.CreationalPatterns.AbstractFactory.Classes
{
    internal class DieselFuelTank : IFuelContainer
    {
        public void GetFuel()
        {
            Console.WriteLine("Getting diesel.");
        }
    }
}
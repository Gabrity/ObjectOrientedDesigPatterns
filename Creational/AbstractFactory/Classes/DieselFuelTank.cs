using System;
using ObjectOrientedDesignPatterns.Interfaces;

namespace ObjectOrientedDesignPatterns.Classes
{
    internal class DieselFuelTank : IFuelContainer
    {
        public void GetFuel()
        {
            Console.WriteLine("Getting diesel.");
        }
    }
}
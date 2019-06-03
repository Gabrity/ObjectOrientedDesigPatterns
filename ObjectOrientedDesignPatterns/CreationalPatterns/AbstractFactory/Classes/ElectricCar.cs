using System;
using ObjectOrientedDesignPatterns.CreationalPatterns.AbstractFactory.Interfaces;

namespace ObjectOrientedDesignPatterns.CreationalPatterns.AbstractFactory.Classes
{
    internal class ElectricCar : ICar
    {
        private IEngine engine;
        private IFuelContainer fuelContainer;

        public ElectricCar(IEngine engine, IFuelContainer fuelContainer)
        {
            this.engine = engine;
            this.fuelContainer = fuelContainer;
        }

        public void Drive()
        {
            engine.Start();
            fuelContainer.GetFuel();
            Console.WriteLine("Electric car started.");
        }
    }
}
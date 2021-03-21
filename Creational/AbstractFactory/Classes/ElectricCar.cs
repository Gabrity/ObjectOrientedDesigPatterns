using System;
using ObjectOrientedDesignPatterns.Interfaces;

namespace ObjectOrientedDesignPatterns.Classes
{
    internal class ElectricCar : ICar
    {
        private readonly IEngine _engine;
        private readonly IFuelContainer _fuelContainer;

        public ElectricCar(IEngine engine, IFuelContainer fuelContainer)
        {
            _engine = engine;
            _fuelContainer = fuelContainer;
        }

        public void Drive()
        {
            _engine.Start();
            _fuelContainer.GetFuel();
            Console.WriteLine("Electric car started.");
        }
    }
}
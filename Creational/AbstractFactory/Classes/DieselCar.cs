using System;
using ObjectOrientedDesignPatterns.Interfaces;

namespace ObjectOrientedDesignPatterns.Classes
{
    internal class DieselCar : ICar
    {
        private readonly IEngine _engine;
        private readonly IFuelContainer _fuelContainer;

        public DieselCar(IEngine engine, IFuelContainer fuelContainer)
        {
            _engine = engine;
            _fuelContainer = fuelContainer;
        }

        public void Drive()
        {
            _engine.Start();
            _fuelContainer.GetFuel();
            Console.WriteLine("Diesel car started.");
        }
    }
}
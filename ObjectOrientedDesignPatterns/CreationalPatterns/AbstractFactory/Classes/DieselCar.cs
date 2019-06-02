﻿using System;

namespace ObjectOrientedDesignPatterns.CreationalPatterns.AbstractFactory
{
    internal class DieselCar : ICar
    {
        private IEngine engine;
        private IFuelContainer fuelContainer;

        public DieselCar(IEngine engine, IFuelContainer fuelContainer)
        {
            this.engine = engine;
            this.fuelContainer = fuelContainer;
        }

        public void Drive()
        {
            engine.Start();
            fuelContainer.GetFuel();
            Console.WriteLine("Diesel car started.");
        }
    }
}
using System;
using ObjectOrientedDesignPatterns.CreationalPatterns.AbstractFactory.Factories;
using ObjectOrientedDesignPatterns.CreationalPatterns.AbstractFactory.Interfaces;

namespace ObjectOrientedDesignPatterns.CreationalPatterns.AbstractFactory
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // choose the concrete factory to get the set of objects you need 

            ICarPartsFactory carPartsFactory = new ElectricCarPartsFactory();
            //ICarPartsFactory carPartsFactory = new DieselCarPartsFactory();

            var engine = carPartsFactory.GetNewEngine();
            var fuelContainer = carPartsFactory.GetNewFuelContainer();

            ICar car = carPartsFactory.GetNewCar(engine, fuelContainer);
            car.Drive();
            Console.ReadKey();
        }
    }
}

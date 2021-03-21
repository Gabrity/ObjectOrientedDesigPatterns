using System;
using ObjectOrientedDesignPatterns.Factories;
using ObjectOrientedDesignPatterns.Interfaces;

namespace ObjectOrientedDesignPatterns
{
    internal class Program
    {
        /*
         * Abstract Factory: Provide an interface for creating families of related or dependent objects without specifying their concrete classes.
         */
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

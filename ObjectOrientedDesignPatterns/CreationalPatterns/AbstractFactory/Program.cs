using ObjectOrientedDesignPatterns.CreationalPatterns.AbstractFactory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedDesignPatterns
{
    class Program
    {
        static void Main(string[] args)
        {
            ICarPartsFactory carPartsFactory = new ElectricCarPartsFactory();

            var engine = carPartsFactory.GetNewEngine();
            var fuelContainer = carPartsFactory.GetNewFuelContainer();

            ICar car = carPartsFactory.GetNewCar(engine, fuelContainer);
            car.Drive();
            Console.ReadKey();
        }
    }
}

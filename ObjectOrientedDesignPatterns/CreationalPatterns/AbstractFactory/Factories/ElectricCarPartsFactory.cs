using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedDesignPatterns.CreationalPatterns.AbstractFactory
{
    class ElectricCarPartsFactory : ICarPartsFactory
    {
        public IFuelContainer GetNewFuelContainer()
        {
            return new ElectricCarBattery();
        }

        public IEngine GetNewEngine()
        {
            return new ElectricEngine();
        }

        public ICar GetNewCar(IEngine engine, IFuelContainer fuelContainer)
        {
            return new ElectricCar(engine, fuelContainer);
        }
    }
}

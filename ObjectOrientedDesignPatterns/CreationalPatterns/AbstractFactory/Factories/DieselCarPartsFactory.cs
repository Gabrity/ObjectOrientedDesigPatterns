using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedDesignPatterns.CreationalPatterns.AbstractFactory
{
    class DieselCarPartsFactory : ICarPartsFactory
    {
        public IFuelContainer GetNewFuelContainer()
        {
            return new DieselFuelTank();
        }

        public IEngine GetNewEngine()
        {
            return new DieselEngine();
        }

        public ICar GetNewCar(IEngine engine, IFuelContainer fuelContainer)
        {
            return new DieselCar(engine, fuelContainer);
        }
    }
}

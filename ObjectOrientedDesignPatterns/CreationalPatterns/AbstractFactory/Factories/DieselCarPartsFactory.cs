using ObjectOrientedDesignPatterns.CreationalPatterns.AbstractFactory.Classes;
using ObjectOrientedDesignPatterns.CreationalPatterns.AbstractFactory.Interfaces;

namespace ObjectOrientedDesignPatterns.CreationalPatterns.AbstractFactory.Factories
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

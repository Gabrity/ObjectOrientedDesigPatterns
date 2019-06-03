using ObjectOrientedDesignPatterns.CreationalPatterns.AbstractFactory.Classes;
using ObjectOrientedDesignPatterns.CreationalPatterns.AbstractFactory.Interfaces;

namespace ObjectOrientedDesignPatterns.CreationalPatterns.AbstractFactory.Factories
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

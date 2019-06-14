using ObjectOrientedDesignPatterns.Classes;
using ObjectOrientedDesignPatterns.Interfaces;

namespace ObjectOrientedDesignPatterns.Factories
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

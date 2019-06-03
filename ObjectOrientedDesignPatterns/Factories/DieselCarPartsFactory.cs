using ObjectOrientedDesignPatterns.Classes;
using ObjectOrientedDesignPatterns.Interfaces;

namespace ObjectOrientedDesignPatterns.Factories
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

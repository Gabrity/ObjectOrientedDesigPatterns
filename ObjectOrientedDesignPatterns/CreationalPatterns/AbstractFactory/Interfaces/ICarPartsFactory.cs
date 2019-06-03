namespace ObjectOrientedDesignPatterns.CreationalPatterns.AbstractFactory.Interfaces
{
    internal interface ICarPartsFactory
    {
        IFuelContainer GetNewFuelContainer();

        IEngine GetNewEngine();

        ICar GetNewCar(IEngine engine, IFuelContainer fuelContainer);
    }
}
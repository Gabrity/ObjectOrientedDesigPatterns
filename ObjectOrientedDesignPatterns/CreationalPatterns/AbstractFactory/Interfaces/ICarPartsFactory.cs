namespace ObjectOrientedDesignPatterns.CreationalPatterns.AbstractFactory
{
    internal interface ICarPartsFactory
    {
        IFuelContainer GetNewFuelContainer();

        IEngine GetNewEngine();

        ICar GetNewCar(IEngine engine, IFuelContainer fuelContainer);
    }
}
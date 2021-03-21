namespace Prototype
{
    public  interface IPrototype
    {
        IPrototype ShallowCopy();
        IPrototype DeepCopy();
    }
}
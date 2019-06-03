namespace ServiceLocator
{
    public interface IServiceLocator
    {
        void RegisterSingletonInstance<T>(T instance);
        T ResolveSingletonInstance<T>();
    }
}
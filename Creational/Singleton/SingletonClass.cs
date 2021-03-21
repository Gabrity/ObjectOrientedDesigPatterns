namespace Singleton
{
    internal class SingletonClass
    {
        private static SingletonClass _instance;

        private SingletonClass()
        {
        }

        public static SingletonClass GetInstance()
        {
            // lazy instantiation
            if (_instance == null)
            {
                _instance = new SingletonClass();
            }

            return _instance;
        }
    }
}
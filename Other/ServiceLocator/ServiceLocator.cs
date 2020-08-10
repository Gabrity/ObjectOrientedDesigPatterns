using System;
using System.Collections.Generic;

namespace ServiceLocator
{
    public class ServiceLocator : IServiceLocator
    {
        private readonly Dictionary<Type, object> _instances;

        public ServiceLocator()
        {
            _instances = new Dictionary<Type, object>();
        }

        void IServiceLocator.RegisterSingletonInstance<T>(T instance)
        {
            var key = typeof(T);
            _instances[key] = instance;
        }

        T IServiceLocator.ResolveSingletonInstance<T>()
        {
            var keySet = typeof(T);
            return (T)_instances[keySet];
        }
    }
}

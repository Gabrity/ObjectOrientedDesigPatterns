using System;
using System.Collections.Generic;

namespace Observer
{
    public class PushMessageSupplier : IObservable<IEmail>, IPushMessageSupplier
    {
        private readonly IList<IObserver<IEmail>> _emailObservers;

        public PushMessageSupplier()
        {
            _emailObservers = new List<IObserver<IEmail>>();
        }

        public void SendMessages(IEmail email)
        {
            foreach (var observer in _emailObservers)
            {
                observer.OnNext(email);
            }
        }

        public IDisposable Subscribe(IObserver<IEmail> observer)
        {
            if (!_emailObservers.Contains(observer))
            {
                _emailObservers.Add(observer);
            }

            return new UnsubscribeHelper(_emailObservers, observer);
        }
    }
}
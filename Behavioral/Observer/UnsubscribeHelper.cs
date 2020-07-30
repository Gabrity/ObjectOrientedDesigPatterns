using System;
using System.Collections.Generic;

namespace Observer
{
    public class UnsubscribeHelper : IDisposable
    {
        private readonly IList<IObserver<IEmail>> _emailObservers;
        private readonly IObserver<IEmail> _observer;

        public UnsubscribeHelper(IList<IObserver<IEmail>> emailObservers, IObserver<IEmail> observer)
        {
            _emailObservers = emailObservers;
            _observer = observer;
        }

        public void Dispose()
        {
            if (_emailObservers.Contains(_observer))
                _emailObservers.Remove(_observer);
        }
    }
}
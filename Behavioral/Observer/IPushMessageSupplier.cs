using System;

namespace Observer
{
    public interface IPushMessageSupplier
    {
        void SendMessages(IEmail email);
        IDisposable Subscribe(IObserver<IEmail> observer);
    }
}
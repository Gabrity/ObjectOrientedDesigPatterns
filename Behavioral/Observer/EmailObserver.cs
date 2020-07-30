using System;

namespace Observer
{
    public class EmailObserver : IObserver<IEmail>
    {
        private readonly string _observerName;

        public EmailObserver(string observerName)
        {
            _observerName = observerName;
        }

        public void OnNext(IEmail value)
        {
            Console.WriteLine($"I, {_observerName}, received an email from {value.Sender}.");
        }

        public void OnError(Exception error)
        {
            Console.WriteLine("Error has occured");
        }

        public void OnCompleted()
        {
            throw new NotImplementedException();
        }
    }
}
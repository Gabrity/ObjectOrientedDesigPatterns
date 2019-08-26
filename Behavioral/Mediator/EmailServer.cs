using System.Collections.Generic;

namespace Mediator
{
    public class EmailServer : IEmailServer
    {
        private readonly IDictionary<string, IList<string>> _pendingEmails;

        public EmailServer()
        {
            _pendingEmails = new Dictionary<string, IList<string>>();
        }

        public void SendEmail(string toAdress, string message)
        {
            if (_pendingEmails.ContainsKey(toAdress))
            {
                _pendingEmails[toAdress].Add(message);
            }
            else
            {
                _pendingEmails[toAdress] = new List<string>() { message };
            }
        }

        public IList<string> CheckForNewMails(string emailAddress)
        {
            if (_pendingEmails.ContainsKey(emailAddress))
            {
                return _pendingEmails[emailAddress];
            }

            return new List<string>();
        }
    }
}
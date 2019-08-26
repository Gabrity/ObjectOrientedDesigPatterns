using System.Collections.Generic;

namespace Mediator
{
    public class EmailServer : IEmailServer
    {
        // List<string> is a very simple representation of the emails in this storage
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
                var newEmails = _pendingEmails[emailAddress];
                _pendingEmails.Remove(emailAddress);
                return newEmails;
            }

            return new List<string>();
        }
    }
}
namespace Observer
{
    public class Email : IEmail
    {
        public string Sender { get; }
        public string MessageText { get; }

        public Email(string sender, string messageText)
        {
            Sender = sender;
            MessageText = messageText;
        }
    }
}
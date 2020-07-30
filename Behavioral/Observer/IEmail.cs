namespace Observer
{
    public interface IEmail
    {
        string Sender { get; }
        string MessageText { get; }
    }
}
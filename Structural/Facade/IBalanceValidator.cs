namespace Facade
{
    internal interface IBalanceValidator
    {
        bool IsValid(double balance, double requestedAmount);
    }
}
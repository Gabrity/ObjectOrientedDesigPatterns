namespace Facade
{
    internal interface ICardReaderValidator
    {
        bool IsValid(string cardChipSignature);
    }
}
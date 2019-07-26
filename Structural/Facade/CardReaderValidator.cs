namespace Facade
{
    public class CardReaderValidator : ICardReaderValidator
    {
        private readonly string _cardChipSignature;

        public CardReaderValidator(string cardChipSignature)
        {
            _cardChipSignature = cardChipSignature;
        }

        public bool IsValid(string cardChipSignature)
        {
            if (cardChipSignature == _cardChipSignature)
            {
                return true;
            }

            return false;
        }
    }
}
namespace Builder.Interfaces
{
    public interface ISwapBuilder
    {
        ISwap Swap { get; }
        void BuildDayCounter();
        void BuildLeg1();
        void BuildLeg2();
    }
}

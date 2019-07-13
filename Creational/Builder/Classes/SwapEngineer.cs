using Builder.Interfaces;

namespace Builder.Classes
{
    public class SwapEngineer
    {
        private readonly ISwapBuilder _swapBuilder;

        public SwapEngineer(ISwapBuilder swapBuilder)
        {
            _swapBuilder = swapBuilder;
        }

        public void MakeSwap()
        {
            _swapBuilder.BuildLeg1();
            _swapBuilder.BuildLeg2();
            _swapBuilder.BuildDayCounter();
        }

        public ISwap GetSwap()
        {
            return _swapBuilder.Swap;
        }        
    }
}

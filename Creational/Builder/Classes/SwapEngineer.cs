using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    public class SwapEngineer
    {
        private ISwapBuilder _swapBuilder;

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

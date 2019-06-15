using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    class Program
    {
        static void Main(string[] args)
        {
            ISwapBuilder swapBuilder = new SwapBuilderFixedFloat();
            // ISwapBuilder swapBuilder = new SwapBuilderFloatFloat();

            var swapEngineer = new SwapEngineer(swapBuilder);

            swapEngineer.MakeSwap();
            var swap = swapEngineer.GetSwap();            
        }
    }
}

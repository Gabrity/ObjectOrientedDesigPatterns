using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade
{
    /* Facade: Provide a unified interface to a set of interfaces in a subsystem. Facade defines a higher-level interface that makes the subsystem easier to use.
    */

    class Program
    {
        static void Main(string[] args)
        {
            var client = new Client();
            client.Manipulate();
            Console.ReadKey();
        }
    }
}

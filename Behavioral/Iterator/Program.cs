using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iterator
{
    /*
     * Iterator: Provide a way to access the elements of an aggregate object sequentially without exposing
     * its underlying representation.
     */
    public class Program
    {
        static void Main(string[] args)
        {
            var bandArray = new BandArrayStorage();
            foreach (var band in bandArray)
            {
                WriteBand(band as IBand);
            }

            var bandList = new BandListStorage();
            foreach (var band in bandList)
            {
                WriteBand(band as IBand);
            }

            Console.ReadKey();
        }

        private static void WriteBand(IBand band)
        {
            Console.WriteLine(band.Name + ", " + band.Genre + ", " + band.NumberOfMembers);
        }
    }
}

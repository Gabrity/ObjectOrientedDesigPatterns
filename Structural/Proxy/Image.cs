using System;
using System.Net.Mime;

namespace Proxy
{
    public class Image : IImage
    {
        // some dummy image values
        public void Draw()
        {
            Console.WriteLine("Drawing a portrait.");
        }

        public int Height()
        {
            return 1920;
        }

        public int Width()
        {
            return 1080;
        }
    }
}

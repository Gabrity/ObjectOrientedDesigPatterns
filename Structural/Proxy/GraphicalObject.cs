namespace Proxy
{
    public class GraphicalObject : IGraphicalObject
    {
        // The image is a heavy object, GraphicalObject always instantiates it
        public IImage Image { get; set; }
        public string Path { get; set; }

        public GraphicalObject(string imageFilePath)
        {
            Path = imageFilePath;
            Image = LoadImageFromFile(imageFilePath);
        }

        private IImage LoadImageFromFile(string imageFilePath)
        {
            return new Image();
        }

        public void Draw()
        {
            Image.Draw();
        }

        public int ImageHeight()
        {
            return Image.Height();
        }

        public int ImageWidth()
        {
            return Image.Width();
        }
    }
}
using System;

namespace Proxy
{
    public class GraphicalObjectProxy : IGraphicalObject
    {
        private readonly string _imageFilePath;
        // lazy instantiation, GraphicalObject is thrown away after being used
        private IGraphicalObject _graphicalObject;
        // width and height are data that the proxy holds as well, even if the image is unloaded
        private int? _height;
        private int? _width;

        public GraphicalObjectProxy(string imageFilePath)
        {
            _imageFilePath = imageFilePath;
        }
        
        public void Draw()
        {
            InstantiateFields();
            _graphicalObject.Draw();
            // garbage collect heavy object
            _graphicalObject = null;
        }

        public int ImageHeight()
        {
            if (_height is null)
            {
                InstantiateFields();
            }
            // garbage collect heavy object
            _graphicalObject = null;

            return _height.Value;
        }

        public int ImageWidth()
        {
            if (_width is null)
            {
                InstantiateFields();
            }
            // garbage collect heavy object
            _graphicalObject = null;

            return _width.Value;
        }

        private void InstantiateFields()
        {
            if (_graphicalObject is null)
            {
                Console.WriteLine("Graphical object is instantiated.");
                _graphicalObject = new GraphicalObject(_imageFilePath);
                _width = _graphicalObject.ImageWidth();
                _height = _graphicalObject.ImageHeight();
            }
        }
    }
}
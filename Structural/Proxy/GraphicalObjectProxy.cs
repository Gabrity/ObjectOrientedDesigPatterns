using System;

namespace Proxy
{
    public class GraphicalObjectProxy : IGraphicalObject
    {
        private readonly string _imageFilePath;
        // lazy instatntiation, GrapicalObjet is thrown away after being used
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
            InstatntiateFields();
            _graphicalObject.Draw();
            // garbage collect heavy object
            _graphicalObject = null;
        }

        public int ImageHeight()
        {
            if (ReferenceEquals(_height, null))
            {
                InstatntiateFields();
            }
            // garbage collect heavy object
            _graphicalObject = null;

            return _height.Value;
        }

        public int ImageWidth()
        {
            if (ReferenceEquals(_width, null))
            {
                InstatntiateFields();
            }
            // garbage collect heavy object
            _graphicalObject = null;

            return _width.Value;
        }

        private void InstatntiateFields()
        {
            if (ReferenceEquals(_graphicalObject, null))
            {
                Console.WriteLine("Graphical object is instatntiated.");
                _graphicalObject = new GraphicalObject(_imageFilePath);
                _width = _graphicalObject.ImageWidth();
                _height = _graphicalObject.ImageHeight();
            }
        }
    }
}
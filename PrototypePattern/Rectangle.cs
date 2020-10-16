using System;

namespace PrototypePattern
{
    internal class Rectangle : IFigure
    {
        private readonly int _height;
        private readonly int _width;

        public Rectangle(int w, int h)
        {
            _width = w;
            _height = h;
        }

        public object Clone()
        {
            return new Rectangle(_width, _height);
        }

        public void GetInfo()
        {
            Console.WriteLine($"Rectangle height {_height} and width {_width}");
        }
    }
}
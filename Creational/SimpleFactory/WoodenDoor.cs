namespace Creational.SimpleFactory
{
    public class WoodenDoor : IDoor
    {
        public WoodenDoor(int height, int width)
        {
            Height = height;
            Width = width;
        }

        private int Height { get; }
        private int Width { get; }

        public int GetHeight()
        {
            return Height;
        }

        public int GetWidth()
        {
            return Width;
        }
    }
}
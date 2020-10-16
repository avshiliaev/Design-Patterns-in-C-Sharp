using System;

namespace PrototypePattern
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            IFigure figure = new Rectangle(30, 40);
            var clonedFigure = (IFigure) figure.Clone();
            figure.GetInfo();
            clonedFigure.GetInfo();

            figure = new Circle(30);
            clonedFigure = (IFigure) figure.Clone();
            figure.GetInfo();
            clonedFigure.GetInfo();

            Console.Read();
        }
    }
}
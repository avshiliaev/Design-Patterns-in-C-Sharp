using System;
using Creational.Prototype.Abstractions;

namespace Creational.Prototype.Prototypes
{
    internal class Color : ColorPrototype
    {
        private readonly int _blue;
        private readonly int _green;
        private readonly int _red;

        // Constructor
        public Color(int red, int green, int blue)
        {
            _red = red;
            _green = green;
            _blue = blue;
        }

        // Create a shallow copy
        public override object Clone()
        {
            Console.WriteLine(
                "Cloning color RGB: {0,3},{1,3},{2,3}",
                _red, _green, _blue);

            return MemberwiseClone() as ColorPrototype ?? throw new Exception("");
        }
    }
}
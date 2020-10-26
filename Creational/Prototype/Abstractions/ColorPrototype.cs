using System;

namespace Creational.Prototype.Abstractions
{
    internal abstract class ColorPrototype : ICloneable
    {
        public abstract object Clone();
    }
}
using System.Collections.Generic;
using Creational.Prototype.Abstractions;

namespace Creational.Prototype.Managers
{
    internal class ColorManager
    {
        private readonly Dictionary<string, ColorPrototype> _colors =
            new Dictionary<string, ColorPrototype>();

        // Indexer
        public ColorPrototype this[string key]
        {
            get => _colors[key];
            set => _colors.Add(key, value);
        }
    }
}
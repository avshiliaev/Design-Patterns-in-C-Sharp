using System;
using System.Collections.Generic;
using System.Linq;
using Structural.Flyweight.Objects;

namespace Structural.Flyweight.Factories
{
    // The Flyweight Factory creates and manages the Flyweight objects. It
    // ensures that flyweights are shared correctly. When the client requests a
    // flyweight, the factory either returns an existing instance or creates a
    // new one, if it doesn't exist yet.
    public class FlyweightFactory
    {
        private readonly List<Tuple<Flyweights.Flyweight, string>> _flyweights =
            new List<Tuple<Flyweights.Flyweight, string>>();

        public FlyweightFactory(params UiWidget[] args)
        {
            foreach (var elem in args)
                _flyweights.Add(
                    new Tuple<Flyweights.Flyweight, string>(new Flyweights.Flyweight(elem), GetKey(elem))
                );
        }

        // Returns a Flyweight's string hash for a given state.
        private string GetKey(UiWidget key)
        {
            var elements = new List<string> {key.Settings, key.Id, key.User};

            if (key.Position != null && key.Color != null)
            {
                elements.Add(key.Color);
                elements.Add(key.Position);
            }

            elements.Sort();

            return string.Join("_", elements);
        }

        // Returns an existing Flyweight with a given state or creates a new
        // one.
        public Flyweights.Flyweight GetFlyweight(UiWidget sharedState)
        {
            var key = GetKey(sharedState);

            if (_flyweights.Count(t => t.Item2 == key) == 0)
            {
                Console.WriteLine("FlyweightFactory: Can't find a flyweight, creating new one.");
                _flyweights.Add(new Tuple<Flyweights.Flyweight, string>(new Flyweights.Flyweight(sharedState), key));
            }
            else
            {
                Console.WriteLine("FlyweightFactory: Reusing existing flyweight.");
            }

            return _flyweights.FirstOrDefault(t => t.Item2 == key)?.Item1;
        }

        public void ListFlyweights()
        {
            var count = _flyweights.Count;
            Console.WriteLine($"\nFlyweightFactory: I have {count} flyweights:");
            foreach (var flyweight in _flyweights)
                Console.WriteLine(flyweight.Item2);
        }
    }
}
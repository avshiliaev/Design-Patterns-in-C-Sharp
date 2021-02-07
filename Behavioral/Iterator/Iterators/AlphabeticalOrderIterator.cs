using Behavioral.Iterator.Abstractions;
using Behavioral.Iterator.Collections;

namespace Behavioral.Iterator.Iterators
{
    // Concrete Iterators implement various traversal algorithms. These classes
    // store the current traversal position at all times.
    internal class AlphabeticalOrderIterator : AbstractIterator
    {
        private readonly WordsCollection _collection;

        private readonly bool _reverse;

        // Stores the current traversal position. An iterator may have a lot of
        // other fields for storing iteration state, especially when it is
        // supposed to work with a particular kind of collection.
        private int _position = -1;

        public AlphabeticalOrderIterator(WordsCollection collection, bool reverse = false)
        {
            _collection = collection;
            _reverse = reverse;

            if (reverse) _position = collection.GetItems().Count;
        }

        protected override object Current()
        {
            return _collection.GetItems()[_position];
        }

        public override int Key()
        {
            return _position;
        }

        public override bool MoveNext()
        {
            var updatedPosition = _position + (_reverse ? -1 : 1);

            if (updatedPosition >= 0 && updatedPosition < _collection.GetItems().Count)
            {
                _position = updatedPosition;
                return true;
            }

            return false;
        }

        public override void Reset()
        {
            _position = _reverse ? _collection.GetItems().Count - 1 : 0;
        }
    }
}
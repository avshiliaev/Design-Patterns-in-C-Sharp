using System.Collections;

namespace Behavioral.Iterator.Abstractions
{
    internal abstract class AbstractIterator : IEnumerator
    {
        object IEnumerator.Current => Current();

        // Move forward to next element
        public abstract bool MoveNext();

        // Rewinds the Iterator to the first element
        public abstract void Reset();

        // Returns the key of the current element
        public abstract int Key();

        // Returns the current element
        protected abstract object Current();
    }
}
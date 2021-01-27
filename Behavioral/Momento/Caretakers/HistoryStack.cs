using System;
using System.Collections.Generic;
using System.Linq;
using Behavioral.Momento.Interfaces;
using Behavioral.Momento.Originators;

namespace Behavioral.Momento.Caretakers
{
    // The Caretaker doesn't depend on the Concrete Memento class. Therefore, it
    // doesn't have access to the originator's state, stored inside the memento.
    // It works with all mementos via the base Memento interface.
    internal class HistoryStack
    {
        private readonly List<IStateContainer> _mementos = new List<IStateContainer>();

        private readonly TextEditor _originator;

        public HistoryStack(TextEditor originator)
        {
            _originator = originator;
        }

        public void Backup()
        {
            _mementos.Add(_originator.Save());
        }

        public void Undo()
        {
            if (_mementos.Count == 0) return;

            var memento = _mementos.Last();
            _mementos.Remove(memento);

            try
            {
                _originator.Restore(memento);
            }
            catch (Exception)
            {
                Undo();
            }
        }

        public void ShowHistory()
        {
            foreach (var memento in _mementos) Console.WriteLine(memento.GetName());
        }
    }
}
using System.Collections.Generic;
using Behavioral.Momento.Interfaces;
using Behavioral.Momento.Momentos;

namespace Behavioral.Momento.Originators
{
    // The Originator holds some important state that may change over time. It
    // also defines a method for saving the state inside a memento and another
    // method for restoring the state from it.
    internal class TextEditor
    {
        // For the sake of simplicity, the originator's state is stored inside a
        // single variable.
        private string _state;

        public TextEditor(string state)
        {
            _state = state;
        }

        // The Originator's business logic may affect its internal state.
        // Therefore, the client should backup the state before launching
        // methods of the business logic via the save() method.
        public void InputText(string input)
        {
            _state = string.Concat(new List<string> {_state, input});
        }

        // Saves the current state inside a memento.
        public IStateContainer Save()
        {
            return new StateContainer(_state);
        }

        // Restores the Originator's state from a memento object.
        public void Restore(IStateContainer memento)
        {
            _state = memento.GetState();
        }
    }
}
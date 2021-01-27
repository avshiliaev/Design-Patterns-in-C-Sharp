using System;

namespace Behavioral.Momento.Interfaces
{
    // The Memento interface provides a way to retrieve the memento's metadata,
    // such as creation date or name. However, it doesn't expose the
    // Originator's state.
    public interface IStateContainer
    {
        string GetName();

        string GetState();

        DateTime GetDate();
    }
}
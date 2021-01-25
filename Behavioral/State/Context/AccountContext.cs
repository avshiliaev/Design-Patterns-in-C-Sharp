using System;
using Behavioral.State.Abstractions;
using Behavioral.State.Interfaces;

namespace Behavioral.State.Context
{
    // The Account defines the interface of interest to clients. It also
    // maintains a reference to an instance of a State subclass, which
    // represents the current state of the Account.
    internal class AccountContext
    {
        // A reference to the current state of the Account.
        private AbstractState _state;

        public AccountContext(AbstractState state)
        {
            TransitionTo(state);
        }

        // The Account allows changing the State object at runtime.
        public void TransitionTo(AbstractState state)
        {
            _state = state;
            _state.SetAccount(this);
        }

        // The Account delegates part of its behavior to the current State
        // object.
        public void CheckLicense(IAccountModel accountEvent)
        {
            _state.HandleCheckLicense(accountEvent);
        }

        public void SaveState()
        {
            _state.HandleSaveState();
        }
        
        public void EmitEvent()
        {
            _state.HandleEmitEvent();
        }

    }
}
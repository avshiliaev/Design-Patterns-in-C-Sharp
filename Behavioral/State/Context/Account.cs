using System;
using Behavioral.State.Abstractions;

namespace Behavioral.State.Context
{
    // The Account defines the interface of interest to clients. It also
    // maintains a reference to an instance of a State subclass, which
    // represents the current state of the Account.
    internal class Account
    {
        // A reference to the current state of the Account.
        private AbstractState _state;

        public Account(AbstractState state)
        {
            TransitionTo(state);
        }

        // The Account allows changing the State object at runtime.
        public void TransitionTo(AbstractState state)
        {
            Console.WriteLine($"Account: Transition to {state.GetType().Name}.");
            _state = state;
            _state.SetAccount(this);
        }

        // The Account delegates part of its behavior to the current State
        // object.
        public void Request1()
        {
            _state.Handle1();
        }

        public void Request2()
        {
            _state.Handle2();
        }
    }
}
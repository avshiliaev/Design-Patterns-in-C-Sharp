using Behavioral.State.Abstractions;
using Behavioral.State.Interfaces;

namespace Behavioral.State.Context
{
    // The Account defines the interface of interest to clients. It also
    // maintains a reference to an instance of a State subclass, which
    // represents the current state of the Account.
    internal class AccountContext : IAccountModel
    {
        // A reference to the current state of the Account.
        private AbstractState _state;

        public AccountContext(AbstractState state, IAccountModel accountModel)
        {
            Balance = accountModel.Balance;
            Approved = accountModel.Approved;
            Pending = accountModel.Pending;
            Blocked = accountModel.Blocked;

            TransitionTo(state);
        }

        public bool Approved { get; set; }
        public bool Pending { get; set; }
        public bool Blocked { get; set; }
        public double Balance { get; set; }

        // The Account allows changing the State object at runtime.
        public void TransitionTo(AbstractState state)
        {
            _state = state;
            _state.SetAccount(this);
        }

        // The Account delegates part of its behavior to the current State
        // object.
        public void CheckBlocked()
        {
            _state.HandleCheckBlocked();
        }

        public void CheckPending()
        {
            _state.HandleCheckPending();
        }

        public void ProcessState()
        {
            _state.HandleProcessState();
        }
    }
}
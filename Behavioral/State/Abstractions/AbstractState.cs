using Behavioral.State.Context;
using Behavioral.State.Interfaces;

namespace Behavioral.State.Abstractions
{
    // The base AbstractState class declares methods that all Concrete State should
    // implement and also provides a backreference to the Account object,
    // associated with the State. This backreference can be used by States to
    // transition the Account to another State.
    internal abstract class AbstractState : IAccountModel
    {
        protected AccountContext Context;
        public double Balance { get; set; }
        public bool Approved { get; set; }
        public bool Pending { get; set; }
        public bool Blocked { get; set; }

        public void SetAccount(AccountContext context)
        {
            Context = context;
            Balance = context.Balance;
            Approved = context.Approved;
            Pending = context.Pending;
            Blocked = context.Blocked;
        }

        public abstract void HandleCheckBlocked();

        public abstract void HandleCheckPending();

        public abstract void HandleProcessState();

    }
}
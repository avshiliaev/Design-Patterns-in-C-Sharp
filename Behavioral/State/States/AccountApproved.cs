using System;
using Behavioral.State.Abstractions;

namespace Behavioral.State.States
{
    // Concrete States implement various behaviors, associated with a state of
    // the Account.
    internal class AccountApproved : AbstractState
    {
        public override void HandleCheckBlocked()
        {
            if (Blocked && !Pending)
                Context.TransitionTo(new AccountBlocked());
        }

        public override void HandleCheckPending()
        {
            if (Pending)
                Context.TransitionTo(new AccountPending());
        }

        public override void HandleProcessState()
        {
            Console.WriteLine("Handle as approved");
        }
    }
}
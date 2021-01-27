using System;
using Behavioral.State.Abstractions;

namespace Behavioral.State.States
{
    // Concrete States implement various behaviors, associated with a state of
    // the Account.
    internal class AccountPending : AbstractState
    {
        public override void HandleCheckBlocked()
        {
            if (Blocked)
                Context.TransitionTo(new AccountBlocked());
            // Otherwise stay.
        }

        public override void HandleCheckPending()
        {
            if (!Pending && Approved)
                Context.TransitionTo(new AccountApproved());
            else if (!Pending && !Approved)
                Context.TransitionTo(new AccountDenied());
            // Otherwise stay.
        }

        public override void HandleProcessState()
        {
            Console.WriteLine("Handle as pending");
        }
    }
}
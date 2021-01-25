using System;
using Behavioral.State.Abstractions;
using Behavioral.State.Interfaces;

namespace Behavioral.State.States
{
    // Concrete States implement various behaviors, associated with a state of
    // the Account.
    internal class AccountBlocked : AbstractState
    {
        public override void HandleCheckBlocked()
        {
            // Remain in the current state.
        }

        public override void HandleCheckPending()
        {
            if(Pending)
                Context.TransitionTo(new AccountPending());
        }
        
        public override void HandleProcessState()
        {
            Console.WriteLine("Handle as blocked");
        }
    }
}
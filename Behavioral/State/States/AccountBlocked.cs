using System;
using Behavioral.State.Abstractions;
using Behavioral.State.Interfaces;

namespace Behavioral.State.States
{
    // Concrete States implement various behaviors, associated with a state of
    // the Account.
    internal class AccountBlocked : AbstractState
    {
        public override void HandleCheckLicense(IAccountModel accountEvent)
        {
            Console.WriteLine("ConcreteStateA handles request1.");
            Console.WriteLine("ConcreteStateA wants to change the state of the context.");
            Context.TransitionTo(new AccountPending());
        }

        public override void HandleSaveState()
        {
            Console.WriteLine("AccountBlocked handles request2.");
        }
        
        public override void HandleEmitEvent()
        {
            
        }
    }
}
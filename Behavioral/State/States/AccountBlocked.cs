using System;
using Behavioral.State.Abstractions;

namespace Behavioral.State.States
{
    // Concrete States implement various behaviors, associated with a state of
    // the Account.
    internal class AccountBlocked : AbstractState
    {
        public override void Handle1()
        {
            Console.WriteLine("ConcreteStateA handles request1.");
            Console.WriteLine("ConcreteStateA wants to change the state of the context.");
            Context.TransitionTo(new AccountPending());
        }

        public override void Handle2()
        {
            Console.WriteLine("AccountBlocked handles request2.");
        }
    }
}
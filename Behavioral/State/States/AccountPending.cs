using System;
using Behavioral.State.Abstractions;

namespace Behavioral.State.States
{
    // Concrete States implement various behaviors, associated with a state of
    // the Account.
    internal class AccountPending : AbstractState
    {
        public override void Handle1()
        {
            Console.Write("ConcreteStateB handles request1.");
        }

        public override void Handle2()
        {
            Console.WriteLine("AccountPending handles request2.");
            Console.WriteLine("AccountPending wants to change the state of the context.");
            Context.TransitionTo(new AccountBlocked());
        }
    }
}
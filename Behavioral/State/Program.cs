using Behavioral.State.Context;
using Behavioral.State.Events;
using Behavioral.State.States;

namespace Behavioral.State
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            // The client code.
            var accountCheckEvent = new AccountCheckEvent
            {
                Balance = 1.0,
                Approved = true,
                Pending = false,
                Blocked = false
            };

            var account = new AccountContext(new AccountPending(), accountCheckEvent);

            account.CheckBlocked();
            account.CheckPending();
            account.ProcessState();
        }
    }
}
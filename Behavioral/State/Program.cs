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
            var newEvent = new AccountCheckEvent
            {
                Balance = 1.0
            };

            var context = new AccountContext(new AccountPending());

            context.CheckLicense(newEvent);
            context.SaveState();
            context.EmitEvent();
        }
    }
}
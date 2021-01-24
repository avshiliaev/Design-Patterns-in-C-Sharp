using Behavioral.State.Context;
using Behavioral.State.States;

namespace Behavioral.State
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            // The client code.
            var context = new Account(new AccountBlocked());
            context.Request1();
            context.Request2();
        }
    }
}
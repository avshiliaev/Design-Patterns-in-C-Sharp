using System;

namespace Behavioral.Command.Handlers
{
    // The Receiver classes contain some important business logic. They know how
    // to perform all kinds of operations, associated with carrying out a
    // request. In fact, any class may serve as a Receiver.
    internal class InputHandler
    {
        public void ProcessUser(string user)
        {
            Console.WriteLine($"Processing user {user}");
        }

        public void ProcessInput(string input)
        {
            Console.WriteLine($"Processing input {input}");
        }
    }
}
using Behavioral.Command.Handlers;
using Behavioral.Command.Interfaces;

namespace Behavioral.Command.Commands
{
    // However, some commands can delegate more complex operations to other
    // objects, called "receivers."
    internal class SubmitInput : ICommand
    {
        private readonly string _input;

        private readonly InputHandler _inputHandler;

        // Context data, required for launching the receiver's methods.
        private readonly string _user;

        // Complex commands can accept one or several receiver objects along
        // with any context data via the constructor.
        public SubmitInput(InputHandler inputHandler, string user, string input)
        {
            _inputHandler = inputHandler;
            _user = user;
            _input = input;
        }

        // Commands can delegate to any methods of a receiver.
        public void Execute()
        {
            _inputHandler.ProcessUser(_user);
            _inputHandler.ProcessInput(_input);
        }
    }
}
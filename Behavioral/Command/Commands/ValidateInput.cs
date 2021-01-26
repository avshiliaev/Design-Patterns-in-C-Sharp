using System;
using Behavioral.Command.Interfaces;

namespace Behavioral.Command.Commands
{
    // Some commands can implement simple operations on their own.
    internal class ValidateInput : ICommand
    {
        private readonly string _payload;

        public ValidateInput(string payload)
        {
            _payload = payload;
        }

        public void Execute()
        {
            Console.WriteLine($"Validating your input... {_payload}");
        }
    }
}
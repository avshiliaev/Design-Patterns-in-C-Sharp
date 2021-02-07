using Behavioral.Command.Commands;
using Behavioral.Command.Handlers;
using Behavioral.Command.Invokers;

namespace Behavioral.Command
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            // The client code can parameterize an invoker with any commands.
            var user = "user";
            var input = "Some input";
            var inputHandler = new InputHandler();

            var signUpForm = new SignUpForm();

            signUpForm.SetOnStart(new ValidateInput(input));
            signUpForm.SetOnFinish(new SubmitInput(inputHandler, user, input));

            signUpForm.Render();
        }
    }
}
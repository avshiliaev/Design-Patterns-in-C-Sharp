using Structural.Decorator.Components;
using Structural.Decorator.Decorators;

namespace Structural.Decorator
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var app = new App();

            var baseNotifier = new ConcreteNotifier();

            var slackNotifier = new SlackNotifierDecorator(baseNotifier);
            var emailSlackNotifier = new EmailNotifierDecorator(slackNotifier);

            app.NotifyUser(emailSlackNotifier);
        }
    }
}
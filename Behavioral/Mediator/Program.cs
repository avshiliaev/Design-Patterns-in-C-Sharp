using System;
using Behavioral.Mediator.Components;

namespace Behavioral.Mediator
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            // The client code.
            var userComponent = new UserComponent();
            var permissionsComponent = new PermissionsComponent();
            var _ = new Mediator(userComponent, permissionsComponent);

            Console.WriteLine("Client triggers operation A.");
            userComponent.CreateNewProject();

            Console.WriteLine();

            Console.WriteLine("Client triggers operation D.");
            permissionsComponent.SendPermissionsChecked();
        }
    }
}
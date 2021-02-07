using System;
using Behavioral.Mediator.Components;
using Behavioral.Mediator.Interfaces;

namespace Behavioral.Mediator
{
    // Concrete Mediators implement cooperative behavior by coordinating several
    // components.
    internal class Mediator : IMediator
    {
        private readonly PermissionsComponent _permissionsComponent;
        private readonly UserComponent _userComponent;

        public Mediator(UserComponent userComponent, PermissionsComponent permissionsComponent)
        {
            _userComponent = userComponent;
            _userComponent.SetMediator(this);

            _permissionsComponent = permissionsComponent;
            _permissionsComponent.SetMediator(this);
        }

        public void Notify(object sender, string ev)
        {
            if (ev == "CreateNewProject")
            {
                Console.WriteLine("Mediator reacts on CreateNewProject and triggers following operations:");
                _permissionsComponent.CheckPermissions();
            }

            if (ev == "SendPermissionsChecked")
            {
                Console.WriteLine("Mediator reacts on SendPermissionsChecked and triggers following operations:");
                _userComponent.SendNotification();
            }
        }
    }
}
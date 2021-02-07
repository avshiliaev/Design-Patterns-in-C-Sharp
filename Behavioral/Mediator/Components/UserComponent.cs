namespace Behavioral.Mediator.Components
{
    // Concrete Components implement various functionality. They don't depend on
    // other components. They also don't depend on any concrete mediator
    // classes.
    internal class UserComponent : BaseComponent
    {
        public void CreateNewProject()
        {
            Mediator.Notify(this, "CreateNewProject");
        }

        public void SendNotification()
        {
            Mediator.Notify(this, "SendNotification");
        }
    }
}
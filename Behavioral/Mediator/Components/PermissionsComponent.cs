namespace Behavioral.Mediator.Components
{
    internal class PermissionsComponent : BaseComponent
    {
        public void CheckPermissions()
        {
            Mediator.Notify(this, "CheckPermissions");
        }

        public void SendPermissionsChecked()
        {
            Mediator.Notify(this, "SendPermissionsChecked");
        }
    }
}
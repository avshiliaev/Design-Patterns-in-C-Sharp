using Behavioral.State.Abstractions;
using Behavioral.State.Interfaces;

namespace Behavioral.State.States
{
    // Concrete States implement various behaviors, associated with a state of
    // the Account.
    internal class AccountDenied : AbstractState
    {
        public override void HandleCheckLicense(IAccountModel accountEvent)
        {
        }

        public override void HandleSaveState()
        {
        }
        
        public override void HandleEmitEvent()
        {
            
        }
    }
}
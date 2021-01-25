using Behavioral.State.Abstractions;
using Behavioral.State.Interfaces;

namespace Behavioral.State.States
{
    // Concrete States implement various behaviors, associated with a state of
    // the Account.
    internal class AccountPending : AbstractState
    {
        public override void HandleCheckLicense(IAccountModel accountEvent)
        {
            if(accountEvent.Balance < 0)
                Context.TransitionTo(new AccountBlocked());
            else
                Context.TransitionTo(new AccountApproved());
        }

        public override void HandleSaveState()
        {
        }
        
        public override void HandleEmitEvent()
        {
            
        }
    }
}
using Behavioral.State.Context;
using Behavioral.State.Interfaces;

namespace Behavioral.State.Abstractions
{
    // The base AbstractState class declares methods that all Concrete State should
    // implement and also provides a backreference to the Account object,
    // associated with the State. This backreference can be used by States to
    // transition the Account to another State.
    internal abstract class AbstractState : IAccountModel
    {
        protected AccountContext Context;
        public double Balance { get; set; }

        public void SetAccount(AccountContext context)
        {
            Context = context;
        }

        public abstract void HandleCheckLicense(IAccountModel accountEvent);

        public abstract void HandleSaveState();

        public abstract void HandleEmitEvent();
    }
}
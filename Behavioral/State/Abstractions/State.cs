using Behavioral.State.Context;

namespace Behavioral.State.Abstractions
{
    // The base AbstractState class declares methods that all Concrete State should
    // implement and also provides a backreference to the Account object,
    // associated with the State. This backreference can be used by States to
    // transition the Account to another State.
    internal abstract class AbstractState
    {
        protected Account Context;

        public void SetAccount(Account context)
        {
            Context = context;
        }

        public abstract void Handle1();

        public abstract void Handle2();
    }
}
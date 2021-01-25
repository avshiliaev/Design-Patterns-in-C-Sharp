using Behavioral.State.Interfaces;

namespace Behavioral.State.Events
{
    public class AccountCheckEvent : IAccountModel
    {
        public double Balance { get; set; }
    }
}
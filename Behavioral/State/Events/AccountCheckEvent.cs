using Behavioral.State.Interfaces;

namespace Behavioral.State.Events
{
    public class AccountCheckEvent : IAccountModel
    {
        public double Balance { get; set; }
        public bool Approved { get; set; }
        public bool Pending { get; set; }
        public bool Blocked { get; set; }
    }
}
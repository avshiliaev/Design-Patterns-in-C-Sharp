namespace Behavioral.State.Interfaces
{
    public interface IAccountModel : IApprovable
    {
        public double Balance { get; set; }
    }
}
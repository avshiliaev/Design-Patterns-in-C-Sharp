namespace Behavioral.ChainOfResponsibility.Interfaces
{
    public interface IRequest
    {
        public bool Valid { get; set; }
        public bool Expected { get; set; }
        public bool Authorized { get; set; }
    }
}
using Behavioral.ChainOfResponsibility.Interfaces;

namespace Behavioral.ChainOfResponsibility.Models
{
    public class Request : IRequest
    {
        public bool Valid { get; set; }
        public bool Expected { get; set; }
        public bool Authorized { get; set; }
    }
}
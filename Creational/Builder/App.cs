using System.Text;

namespace Creational.Builder
{
    internal class App
    {
        private readonly int _apiVersion;
        private bool _useAuthentication;
        private bool _useCors;
        private bool _useGrpc;
        private bool _useValidation;

        public App(AppBuilder builder)
        {
            _apiVersion = builder.Version;
            _useCors = builder.Cors;
            _useAuthentication = builder.Authentication;
            _useValidation = builder.Validation;
            _useGrpc = builder.Grpc;
        }

        public string GetDescription()
        {
            var sb = new StringBuilder();
            sb.Append($"This is {_apiVersion} version of API. ");
            return sb.ToString();
        }
    }
}
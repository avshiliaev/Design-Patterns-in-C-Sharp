namespace Creational.Builder
{
    internal class AppBuilder
    {
        public bool Authentication;
        public bool Cors;
        public bool Grpc;
        public bool Validation;
        public int Version;

        public AppBuilder(int version)
        {
            Version = version;
        }

        public AppBuilder AddCors()
        {
            Cors = true;
            return this;
        }

        public AppBuilder AddAuthentication()
        {
            Authentication = true;
            return this;
        }

        public AppBuilder AddValidation()
        {
            Validation = true;
            return this;
        }

        public AppBuilder AddGrpc()
        {
            Grpc = true;
            return this;
        }

        public App Build()
        {
            return new App(this);
        }
    }
}
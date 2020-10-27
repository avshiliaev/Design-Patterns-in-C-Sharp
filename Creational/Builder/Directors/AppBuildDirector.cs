using Creational.Builder.Interfaces;

namespace Creational.Builder.Directors
{
    // The Director is only responsible for executing the building steps in a
    // particular sequence. It is helpful when producing products according to a
    // specific order or configuration.
    //
    // Strictly speaking, the Director class is optional, since the client can
    // control builders directly.
    public class AppBuildDirector
    {
        private IAppBuilder _builder;

        public IAppBuilder Builder
        {
            set => _builder = value;
        }

        // The Director can construct several product variations using the same
        // building steps.
        public void BuildAppDevelopmentMode()
        {
            _builder.BuildInputValidation();
        }

        public void BuildAppProductionMode()
        {
            _builder.BuildAuthentication();
            _builder.BuildAuthorization();
            _builder.BuildInputValidation();
        }
    }
}
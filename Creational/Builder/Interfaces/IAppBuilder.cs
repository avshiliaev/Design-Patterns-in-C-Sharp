namespace Creational.Builder.Interfaces
{
    // The Builder interface specifies methods for creating the different parts
    // of the App objects.
    public interface IAppBuilder
    {
        void BuildInputValidation();

        void BuildAuthentication();

        void BuildAuthorization();
    }
}
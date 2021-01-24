namespace Structural.Facade.Library
{
    // The Subsystem can accept requests either from the facade or client
    // directly. In any case, to the Subsystem, the Facade is yet another
    // client, and it's not a part of the Subsystem.
    public class AudioEncoder
    {
        public string operation1()
        {
            return "AudioEncoder: Ready!\n";
        }

        public string operationN()
        {
            return "AudioEncoder: Go!\n";
        }
    }
}
namespace Structural.Facade.Library
{
    // Some facades can work with multiple subsystems at the same time.
    public class VideoEncoder
    {
        public string operation1()
        {
            return "VideoEncoder: Get ready!\n";
        }

        public string operationZ()
        {
            return "VideoEncoder: Fire!\n";
        }
    }
}
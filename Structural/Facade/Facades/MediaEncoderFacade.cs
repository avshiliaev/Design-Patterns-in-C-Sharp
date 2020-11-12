using Structural.Facade.Library;

namespace Structural.Facade.Facades
{
    // The Facade class provides a simple interface to the complex logic of one
    // or several subsystems. The Facade delegates the client requests to the
    // appropriate objects within the subsystem. The Facade is also responsible
    // for managing their lifecycle. All of this shields the client from the
    // undesired complexity of the subsystem.
    public class MediaEncoderFacade
    {
        protected AudioEncoder _audioEncoder;

        protected VideoEncoder _videoEncoder;

        public MediaEncoderFacade(AudioEncoder audioEncoder, VideoEncoder videoEncoder)
        {
            _audioEncoder = audioEncoder;
            _videoEncoder = videoEncoder;
        }

        // The Facade's methods are convenient shortcuts to the sophisticated
        // functionality of the subsystems. However, clients get only to a
        // fraction of a subsystem's capabilities.
        public string Encode(string media)
        {
            var result = "Facade initializes subsystems:\n";
            result += _audioEncoder.operation1();
            result += _videoEncoder.operation1();
            result += "Facade orders subsystems to perform the action:\n";

            result += $"Source: {media}";

            result += _audioEncoder.operationN();
            result += _videoEncoder.operationZ();

            return result;
        }
    }
}
using Structural.Facade.Facades;
using Structural.Facade.Library;

namespace Structural.Facade
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            // The client code may have some of the subsystem's objects already
            // created. In this case, it might be worthwhile to initialize the
            // Facade with these objects instead of letting the Facade create
            // new instances.
            var audioEncoder = new AudioEncoder();
            var videoEncoder = new VideoEncoder();
            var mediaEncoder = new MediaEncoderFacade(audioEncoder, videoEncoder);
            
            App.EncodeUserVideoClip(mediaEncoder, "some_user_video_clip");
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventsAndDelegates
{
    class Program
    {
        static void Main(string[] args)
        {
            var video = new Video() { Title = "New Video" };
            var videoEncoder = new VideoEncoder(); //publisher
            var mailService = new MailService(); //subscriber
            var messageService = new MessageService(); //subscriber

            //add event handlers (subscribers) to VideoEncoded event (which is a delegate of type VideoEncodedEventHandler)
            //(send _reference_ of the method, so don't call it, i.e., add () at the end) 
            videoEncoder.VideoEncoded += mailService.OnVideoEncoded;
            videoEncoder.VideoEncoded += messageService.OnVideoEncoded;

            videoEncoder.Encode(video);
            //once encoded, VideoEncoded event will fire
        }
    }

    
}

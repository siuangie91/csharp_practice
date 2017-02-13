using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace EventsAndDelegates
{
    public class VideoEncoder
    {
        // 1. Define a delegate
        // 2. Define an event based on that delegate
        // 3. Raise the event

        // The default event arguments param is an EventArgs object : 
        //public delegate void VideoEncodedEventHandler(object source, EventArgs args);
        // But you can create a custom event arguments object that derives from EventArgs to pass in data
        public delegate void VideoEncodedEventHandler(object source, VideoEventArgs args);
        public event VideoEncodedEventHandler VideoEncoded; //when raised, call method on the subscriber that conforms to delegate

        //same as using EventHandler delegate type (don't have to create custom delegate)
        //2 forms: EventHandler or EventHandler<TEventArgs>
        //public event EventHandler<VideoEventArgs> VideoEncoded;

        public void Encode(Video video)
        {
            Console.WriteLine("Encoding video... ");
            Thread.Sleep(3000);

            // raise OnVideoEncoded event when finished
            OnVideoEncoded(video);
        }

        // Convention: Event publisher methods should be protected virtual void; name should be prefixed with "On"
        protected virtual void OnVideoEncoded(Video video)
        {
            // check to see if event has any subscribers
            if(VideoEncoded != null)
            {
                // pass this object as the source, and specify an empty EventArgs object (no other data to pass)
                //VideoEncoded(this, EventArgs.Empty);

                //pass VideoEventArgs object to pass custom data
                //fire VideoEncoded event handler, which will call the methods attached to the delegate
                VideoEncoded(this, new VideoEventArgs() { Video = video});
            }
        }
    }
}
